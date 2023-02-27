using System.ComponentModel.DataAnnotations;

namespace Projekt.Models.DTO
{
    public class RegistrationModel
    {
        [Required]
        public string Name{ get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string UserName { get; set; }
        [Required]
        [RegularExpression("(?=.*?[a-z])(?=.*?[0-9]).{4,}$", ErrorMessage = "Minimum length is 4 letters and must contain 1 digit")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Passwords are not the same")]
        public string PasswordConfirmation { get; set; }
        public string Role { get; set; }

    }
}
