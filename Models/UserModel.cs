using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DiabetesApp.Models
{
    public class UserModel
    {
       
        public string FullName {  get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [PasswordPropertyText]
        [MinLength(8 , ErrorMessage = "")]
        [MaxLength(12, ErrorMessage = "")]
        
        public string Password { get; set; } = string.Empty;
    }
}
