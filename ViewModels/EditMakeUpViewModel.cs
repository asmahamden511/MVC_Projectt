using MVC_Projec2.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.ViewModels
{
    public class EditMakeUpViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Session type is required")]
        [StringLength(100, ErrorMessage = "Session type must not exceed 100 characters")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Session duration is required")]
        [Range(1, 300, ErrorMessage = "Session duration must be between 1 and 300 minutes")]
        public int Price { get; set; }


        [Required(ErrorMessage = "Session image is required")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Session image is required")]
        public IFormFile ImageFile { get; set; }
        public List<MakeUpImages> Images { get; set; } = new List<MakeUpImages>();

    }
}
