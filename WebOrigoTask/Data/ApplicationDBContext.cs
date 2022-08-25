using Microsoft.EntityFrameworkCore;

namespace WebOrigoTask.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<device> Tablets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=./Data/ManagerPortal.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            device[] tabletsToSeed = new device[6];
            for (int i = 1; i <= 6; i++)
            {
                tabletsToSeed[i - 1] = new device
                {
                    device_id = i,
                    device_type = "unset",
                    activation_code = "XJ235IAH245D2O"
                };
            }

            modelBuilder.Entity<device>().HasData(tabletsToSeed);
        }
    }
}
