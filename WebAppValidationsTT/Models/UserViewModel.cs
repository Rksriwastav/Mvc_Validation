using System.ComponentModel.DataAnnotations;
namespace WebAppValidationsTT.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage ="Please enter name")]
        [Display(Description = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter username")]
        [Display(Name = "Username")]
        [RegularExpression(".+@.+\\..+", ErrorMessage = "Please enter correct username")]
        public string Username { get; set; }

        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Confirm password doesn't matched")]
        public string ConfirmPassword { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter contact number")]
        [RegularExpression(@"^[789]\d{9}$", ErrorMessage = "Please enter correct mobile")]
        public string Contact { get; set; }

        [Required(ErrorMessage ="Pleage enter your age")]
        [Range(18, 30, ErrorMessage = "Age must be between 18 and 30")]
        public string Age { set; get; }
        
    }
}