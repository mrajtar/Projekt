using System.ComponentModel.DataAnnotations;

namespace Projekt.Models.DTO
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [RegularExpression("(?=.*?[a-z])(?=.*?[0-9]).{4,}$", ErrorMessage = "Minimum length is 4 letters and must contain 1 digit")]
        public string Password { get; set; }
        
    }
}
