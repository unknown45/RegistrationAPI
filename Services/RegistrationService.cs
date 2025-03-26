using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RegistrationAPI.Data;
using RegistrationAPI.Model;

namespace RegistrationAPI.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly AppDBContext _context;

        public RegistrationService(AppDBContext context)
        {
            _context = context;
        }

        public async Task<bool> RegisterAsync(RegistrationEntity registration)
        {
            _context.Registrations.Add(new RegistrationEntity
            {
                CompanyName = registration.CompanyName,
                NPWP = registration.NPWP,
                DirectorName = registration.DirectorName,
                PICName = registration.PICName,
                Email = registration.Email,
                PhoneNumber = registration.PhoneNumber,
                NPWPFilePath = registration.NPWPFilePath,
                PowerOfAttorneyFilePath = registration.PowerOfAttorneyFilePath
            });
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
