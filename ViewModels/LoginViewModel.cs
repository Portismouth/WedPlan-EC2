using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress (ErrorMessage = "Need a valid email")]
        [Required (ErrorMessage = "Need an email")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Need a password")]
        [DataType (DataType.Password)]
        public string Password { get; set; }
    }
}