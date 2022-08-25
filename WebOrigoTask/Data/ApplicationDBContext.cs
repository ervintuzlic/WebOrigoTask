using Microsoft.EntityFrameworkCore;

namespace WebOrigoTask.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<device> Tablets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=./Data/Manager_Portal.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            device[] devicesToSeed = new device[6];
            for (int i = 1; i <= 6; i++)
            {
                devicesToSeed[i - 1] = new device
                {
                    deviceId = "NW-H-20-0017",
                    deviceType = "unset",
                    activationCode = "XJ235IAH245D2O"
                };
            }

            modelBuilder.Entity<device>().HasData(new[]
            {
                    new device
                    {
                        deviceId = "NW-H-20-0017",
                        deviceType = "unset",
                        activationCode = "XJ235IAH245D2O"
                    }
            });
        }
    }
}
