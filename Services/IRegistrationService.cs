using RegistrationAPI.Model;

namespace RegistrationAPI.Services
{
    public interface IRegistrationService
    {
        Task<bool> RegisterAsync(RegistrationEntity registration);
    }
}
