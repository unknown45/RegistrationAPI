using Microsoft.EntityFrameworkCore;
using RegistrationAPI.Model;

namespace RegistrationAPI.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<RegistrationEntity> Registrations { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
    }
}
