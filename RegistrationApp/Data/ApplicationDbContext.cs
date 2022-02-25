using Microsoft.EntityFrameworkCore;
using RegistrationApp.Models;

namespace RegistrationApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Staff> Staff { get; set; }

        public DbSet<Guest> Guest { get; set; }
    }
}
