using System.ComponentModel.DataAnnotations;

namespace MVC_Projec2.ViewModels
{
    public class Register
    {
        [Required(ErrorMessage = " Name is required .")]
        public string FullName { get; set; }

        [Required(ErrorMessage = " Email is required .")]
        [EmailAddress]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = " Password is required .")]
        [DataType(DataType.Password)]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and max at {1}")]
        [Display(Name = "New Password .")]
        public string Password { get; set; }


        [Required(ErrorMessage = " Confirm password is required .")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Confirm Password .")]
        public string ConfirmPassword { get; set; }



    }
}
