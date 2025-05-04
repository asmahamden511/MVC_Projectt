using MVC_Projec2.Models;

namespace MVC_Projec2.ViewModels
{
    public class MakeUpCommentViewModel
    {
        public MakeUp_Service makeUp { get; set; }
        public List<Comment> Comments { get; set; }
        public string CommentText { get; set; }
        public string UserId { get; set; }
    }
}
