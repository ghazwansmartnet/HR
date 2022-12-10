using HR_SMARTENET.Models.EmploeeDetails;
using Microsoft.EntityFrameworkCore;

namespace HR_SMARTENET.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<MarriageStatus> MarriageStatuses { get; set; }
    }
}
