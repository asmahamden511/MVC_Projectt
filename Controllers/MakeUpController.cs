using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using MVC_Projec2.Hubs;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;
using MVC_Projec2.Services;
using MVC_Projec2.ViewModels;
using System;

namespace MVC_Projec2.Controllers
{
    public class MakeUpController : Controller
    {
        private readonly IHubContext<CommentHub> _hubContext;
        private readonly ICommentRepository _commentRepository;
        private readonly IMakeUpRepository _makeUpRepository;
        private readonly IImageUploadService _imageUploadService;
        private readonly ILogger<SessionController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;


        public MakeUpController(
            UserManager<ApplicationUser> userManager,
            IHubContext<CommentHub> hubContext,
            ICommentRepository commentRepository,
            IMakeUpRepository makeUpRepository,
            IImageUploadService imageUploadService,
            ILogger<SessionController> logger)
        {
            this._hubContext = hubContext;
            this._makeUpRepository = makeUpRepository;
            this._commentRepository = commentRepository;
            this._imageUploadService = imageUploadService;
            this._logger = logger;
        }

        public IActionResult GetAll()
        {
            try
            {
                return View(_makeUpRepository.GetAll());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving MakeUp_Service items");
                return View(new List<MakeUp_Service>());
            }
        }

        public IActionResult Details(int id)
        {
            var makeUp = _makeUpRepository.GetByIdWithImages(id);
            if (makeUp == null)
            {
                return NotFound();
            }

            var comments = _commentRepository.GetCommentsByService(id, ServiceType.MakeUp);

            var viewModel = new MakeUpCommentViewModel
            {
                makeUp = makeUp,
                Comments = comments,
                CommentText = ""
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(MakeUpCommentViewModel model)
        {
            if (string.IsNullOrEmpty(model.CommentText))
            {
                ModelState.AddModelError("", "Please provide a comment.");
                return RedirectToAction("Details", new { id = model.makeUp.Id });
            }

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return Unauthorized();
            }

            var comment = new Comment
            {
                Content = model.CommentText,
                CreatedAt = DateTime.Now,
                ServiceType = ServiceType.Decor,
                UserId = user.Id,
                ServiceId = model.makeUp.Id
            };

            _commentRepository.insert(comment);
            _commentRepository.Save();


            await _hubContext.Clients.All.SendAsync("NewCommentNotify", user.UserName, model.CommentText, model.makeUp.Id, "MakeUp");

            return RedirectToAction("Details", new { id = model.makeUp.Id });
        }

        public IActionResult Search(string searchValue)
        {
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                return RedirectToAction("GetAll");
            }

            try
            {
                var makeUp_s = _makeUpRepository.SearchByName(searchValue);
                return View("SearchName", makeUp_s);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching Makeup");
                TempData["ErrorMessage"] = "An error occurred during search";
                return RedirectToAction("GetAll");
            }
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Add()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(AddMakeUpViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var makeUp = new MakeUp_Service
                {
                    Name = model.Name,
                    Price = model.Price
                };

                foreach (var file in model.ImageFiles)
                {
                    var imageUrl = await _imageUploadService.UploadImageAsync(file);
                    makeUp.Images.Add(new MakeUpImages { ImageUrl = imageUrl });
                }

                _makeUpRepository.insert(makeUp);
                _makeUpRepository.Save();

                TempData["SuccessMessage"] = "MakeUp Service created successfully!";
                return RedirectToAction("GetAllMackeups", "Dashboard");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding MakeUp");
                ModelState.AddModelError("", "Error creating MakeUp. Please check the image format (JPG/PNG only)");
                return View("Add", model);
            }
        }

        //[Authorize(Roles = "Admin")]
        [AllowAnonymous]
        public async Task<IActionResult> Edit(int id)
        {
            var makeUp = _makeUpRepository.GetByIdWithImages(id);
            if (makeUp == null)
            {
                return NotFound();
            }

            var viewModel = new EditMakeUpViewModel
            {
                Images = makeUp.Images,
                Name = makeUp.Name,
                Price = makeUp.Price,
                ImageUrl = makeUp.ImageUrl,
            };

            return View(viewModel);
        }

        [AllowAnonymous]
        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> SaveEdit(EditMakeUpViewModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(model);
            //}

            try
            {
                var makeUp = _makeUpRepository.GetById(model.Id);
                if (makeUp == null)
                {
                    return NotFound();
                }

                makeUp.Name = model.Name;
                makeUp.Price = model.Price;

                _makeUpRepository.Update(makeUp);
                _makeUpRepository.Save();

                TempData["SuccessMessage"] = "MakeUp_Service updated successfully!";
                return RedirectToAction("GetAllMackeups", "Dashboard");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating MakeUp_Service");
                ModelState.AddModelError("", "Error updating MakeUp_Service. Please try again.");
                return View(model);
            }
        }

      //  [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            try
            {
                var makeUp = _makeUpRepository.GetById(id);
                if (makeUp == null)
                {
                    return NotFound();
                }

                if (makeUp.Images != null && makeUp.Images.Count() > 0)
                {
                    foreach (var image in makeUp.Images)
                    {
                        _imageUploadService.DeleteImage(image.ImageUrl);
                    }

                }


                _makeUpRepository.Delete(makeUp);
                _makeUpRepository.Save();

                TempData["SuccessMessage"] = "MakeUp_Service and its image were deleted successfully!";
                return RedirectToAction("GetAllMackeups", "Dashboard");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting MakeUp_Service ID {SessionId}", id);

                TempData["ErrorMessage"] = "Error deleting MakeUp_Service. Please try again.";
                return RedirectToAction("GetAllMackeups", "Dashboard");
            }
        }

    }
}
