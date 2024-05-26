using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DiabetesApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please provide your username")]
        [RegularExpression(@"^[A-Za-z]+\.[A-Za-z]+$", ErrorMessage = "Use the format Lastname.Firstname")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide your password")]
        [PasswordPropertyText]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        [MaxLength(12, ErrorMessage = "Password must be less than 12 characters long")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character")]

        public string Password { get; set; } = string.Empty;
    }
}
