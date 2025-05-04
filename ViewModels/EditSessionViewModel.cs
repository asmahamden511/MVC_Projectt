using MVC_Projec2.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.ViewModels
{
    public class EditSessionViewModel
    {
       public int Id { get; set; }

       [Required(ErrorMessage = "Session type is required")]
       [StringLength(100, ErrorMessage = "Session type must not exceed 100 characters")]
       public string Type { get; set; }

       [Required(ErrorMessage = "Session duration is required")]
       [Range(1, 300, ErrorMessage = "Session duration must be between 1 and 300 minutes")]
       public int Duration { get; set; }

       public string? ImageUrl { get; set; }

       //[AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" }, ErrorMessage = "Only .jpg, .jpeg, .png extensions are allowed.")]
       public IFormFile? ImageFile { get; set; }
       public List<SessionImages> Images { get; set; } = new List<SessionImages>();

    }
}
