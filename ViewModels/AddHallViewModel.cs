using MVC_Projec2.Custom_Validation;
using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.ViewModels
{
    public class AddHallViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 1000)]
        public int Capacity { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [Range(0.1, double.MaxValue)]
        public double Price { get; set; }

        [Display(Name = "Hall Images")]
        //[Required(ErrorMessage = "At least one image is required")]
        //[MinLength(1, ErrorMessage = "At least one image is required")]
        //[MaxLength(5, ErrorMessage = "Maximum 5 images allowed")]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        
        public List<IFormFile> ImageFiles { get; set; } = new List<IFormFile>();
    }
}
