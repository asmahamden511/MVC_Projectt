using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using MVC_Projec2.Models;
using MVC_Projec2.Repository;

namespace MVC_Projec2.Hubs
{
    public class CommentHub:Hub
    {
        private readonly ICommentRepository _commentRepo;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<CommentHub> _logger;


        public CommentHub(ILogger<CommentHub> logger,
                          ICommentRepository commentRepo,
                          UserManager<ApplicationUser> userManager)
        {
            _commentRepo = commentRepo;
            _userManager = userManager;
            _logger = logger;
        }

        public async Task Ping()
        {
            await Clients.Caller.SendAsync("Pong");
        }

        public override async Task OnConnectedAsync()
        {
            Console.WriteLine("SignalR connected: " + Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            Console.WriteLine("SignalR disconnected: " + Context.ConnectionId);
            if (exception != null)
            {
                Console.WriteLine("Disconnect error: " + exception.Message);
            }
            await base.OnDisconnectedAsync(exception);
        }

        public async Task NewCommentArrived(string userName, string commentText, int modelId, string modelType)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(commentText))
            {
                throw new ArgumentException("Invalid comment data.");
            }

            if (!Enum.TryParse(modelType, true, out ServiceType serviceType))
            {
                throw new Exception($"Unknown model type: {modelType}");
            }

            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
                throw new Exception("User not found.");

            var comment = new Comment
            {
                Content = commentText,
                CreatedAt = DateTime.Now,
                UserId = user.Id,
                ServiceId = modelId,
                ServiceType = serviceType
            };

            try
            {
                _commentRepo.insert(comment);
                _commentRepo.Save();
                await Clients.All.SendAsync("NewCommentNotify", userName, commentText, modelId, modelType);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CommentHub: {ex.Message}");
                throw new Exception("Error processing the comment", ex);
            }
        }

    }
}

