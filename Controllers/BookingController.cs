using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;

namespace MVC_Projec2.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingReposirtory _bookingRepo;
        private readonly MVCProjectContext _context;

        public BookingController(IBookingReposirtory bookingRepo, MVCProjectContext context)
        {
            _bookingRepo = bookingRepo;
            _context = context;
        }

        public IActionResult Index()
        {
            var bookings = _bookingRepo.GetAll();
            return View(bookings);
        }

        public IActionResult Details(int id)
        {
            var booking = _bookingRepo.GetById(id);
            if (booking == null)
                return NotFound();

            return View(booking);
        }

        public IActionResult Create()
        {
            LoadDropDowns();
            ViewData["Message"] = "Create a new Booking";
            return View();
        }

        [HttpPost]
        public IActionResult Create(Booking booking)
        {
            if (ModelState.IsValid)
            {
                booking.Created_at = DateTime.Now;
                booking.Status = "Pending";
                _bookingRepo.insert(booking);
                _bookingRepo.Save();
                return RedirectToAction("Index");
            }

            LoadDropDowns();
            ViewData["Error"] = "Invalid data!";
            return View(booking);
        }

        public IActionResult Edit(int id)
        {
            var booking = _bookingRepo.GetById(id);
            if (booking == null)
                return NotFound();

            LoadDropDowns();
            ViewData["Message"] = "Edit Booking";
            return View(booking);
        }

        [HttpPost]
        public IActionResult Edit(Booking booking)
        {
            if (ModelState.IsValid)
            {
                _bookingRepo.Update(booking);
                _bookingRepo.Save();
                return RedirectToAction("Index");
            }

            LoadDropDowns();
            return View(booking);
        }

        public IActionResult Delete(int id)
        {
            var booking = _bookingRepo.GetById(id);
            if (booking == null)
                return NotFound();

            return View(booking);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var booking = _bookingRepo.GetById(id);
            if (booking != null)
            {
                _bookingRepo.Delete(booking);
                _bookingRepo.Save();
            }

            return RedirectToAction("Index");
        }

        private void LoadDropDowns()
        {
            ViewData["Halls"] = new SelectList(_context.Halls.ToList(), "Id", "Name");
            ViewData["Sessions"] = new SelectList(_context.Sessions.ToList(), "Id","Duration");
            ViewData["Ateliers"] = new SelectList(_context.Ateliers.ToList(), "Id", "Name");
            ViewData["MakeUps"] = new SelectList(_context.MakeUpServices.ToList(), "Id", "Name");
            ViewData["Decors"] = new SelectList(_context.Decors.ToList(), "Id", "Style");
        }
    }
}
