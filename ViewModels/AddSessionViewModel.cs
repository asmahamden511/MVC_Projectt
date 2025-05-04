using MVC_Projec2.Custom_Validation;
using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.ViewModels
{
    public class AddSessionViewModel
    {

        [Required(ErrorMessage = "Session type is required")]
        [StringLength(100, ErrorMessage = "Session type must not exceed 100 characters")]
        public string Type { get; set; }


        [Required(ErrorMessage = "Session duration is required")]
        [Range(1, 300, ErrorMessage = "Session duration must be between 1 and 300 minutes")]
        public int Duration { get; set; }


        [Display(Name = "Session Images")]
        //[Required(ErrorMessage = "At least one image is required")]
        //[MinLength(1, ErrorMessage = "At least one image is required")]
        //[MaxLength(5, ErrorMessage = "Maximum 5 images allowed")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]

        public List<IFormFile> ImageFiles { get; set; } = new List<IFormFile>();


    }
}
