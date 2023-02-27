using Projekt.Models.DTO;

namespace Projekt.Repositories.Absract
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginModel model);
        Task<Status> RegisterAsync(RegistrationModel model);
        Task LogoutAsync();
        
        
    }
}
