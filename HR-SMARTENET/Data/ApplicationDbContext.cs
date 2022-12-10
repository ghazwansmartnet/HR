using HR_SMARTENET.Models.EmploeeDetails;
using Microsoft.EntityFrameworkCore;

namespace HR_SMARTENET.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BloodType> bloodTypes { get; set; }
    }
}
