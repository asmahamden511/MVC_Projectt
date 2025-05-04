using MVC_Projec2.Custom_Validation;
using MVC_Projec2.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.ViewModels
{
    public class EditHallViewModel
    {
        public int Id { get; set; }

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

        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]

        public IFormFile NewImageFile { get; set; }
        public List<HallImage> Images { get; set; } = new List<HallImage>();

    }
}
