using MVC_Projec2.Custom_Validation;
using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.ViewModels
{
    public class AddDecorViewModel
    {
        [Required]
        public string Style { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Price { get; set; }

        public string Description { get; set; }

        //[Required(ErrorMessage = "At least one image is required")]
        //[MinLength(1, ErrorMessage = "At least one image is required")]
        [AllowedExtensions(new[] { ".jpg", ".jpeg", ".png" })]
       
        public List<IFormFile> ImageFiles { get; set; } = new();
    }
}
