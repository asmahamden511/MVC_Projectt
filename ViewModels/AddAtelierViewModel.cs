using MVC_Projec2.Custom_Validation;
using MVC_Projec2.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.ViewModels
{
    public class AddAtelierViewModel
    {
        [Required]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string? Location { get; set; }
        public double? priceRange { get; set; }
        public List<AtelierImages> Images { get; set; } = new List<AtelierImages>();
        
        //[Required(ErrorMessage = "At least one image is required")]
        //[MinLength(1, ErrorMessage = "At least one image is required")]
        [AllowedExtensions(new[] { ".jpg", ".jpeg", ".png" })]

        public List<IFormFile> ImageFiles { get; set; } = new();
    }
}
