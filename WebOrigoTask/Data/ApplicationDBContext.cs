using Microsoft.EntityFrameworkCore;

namespace WebOrigoTask.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<DeviceRegisterRequest> Devices { get; set; }
        public DbSet<DeviceInfoResponse> deviceInfoResponses { get; set; }

        public DbSet<DeviceOwnerDetails> DeviceOwnerDetails { get; set; }

        public DbSet<LeasingPeriods> LeasingPeriods { get; set; }

        public DbSet<LeasingPeriodsComputed> LeasingPeriodsComputeds { get; set; }

        public DbSet<ErrorResponse> errorResponses { get; set; }

        public DbSet<LeasingUpdateRequest> leasingUpdateRequests { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=./Data/Manager_Portal.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DeviceRegisterRequest[] devicesToSeed = new DeviceRegisterRequest[6];
            for (int i = 1; i <= 6; i++)
            {
                devicesToSeed[i - 1] = new DeviceRegisterRequest
                {
                    deviceId = "NW-H-20-0017",
                    deviceType = "unset",
                    activationCode = "XJ235IAH245D2O"
                };
            }

            modelBuilder.Entity<DeviceRegisterRequest>().HasData(new[]
            {
                    new DeviceRegisterRequest
                    {
                        deviceId = "NW-H-20-0017",
                        deviceType = "unset",
                        activationCode = "XJ235IAH245D2O"
                    }
            });
        }
    }
}
