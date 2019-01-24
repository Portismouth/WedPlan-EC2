using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.ViewModels
{
    public class RegViewModel
    {
        [Required(ErrorMessage = "Need a first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Need a last name")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Need a valid email")]
        [Required(ErrorMessage = "Need an email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Need a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Need a confirm password")]
        [Compare("Password", ErrorMessage = "Passwords must match")]
        public string ConfPassword { get; set; }
    }
}