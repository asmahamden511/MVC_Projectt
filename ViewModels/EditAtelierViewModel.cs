using MVC_Projec2.Custom_Validation;
using MVC_Projec2.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.ViewModels
{
    public class EditAtelierViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public string? Location { get; set; }

        public double? priceRange { get; set; }

        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile NewImageFile { get; set; }

        public List<AtelierImages> Images { get; set; } = new List<AtelierImages>();

    }
}
