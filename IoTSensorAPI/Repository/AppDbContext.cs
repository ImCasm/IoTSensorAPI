using IoTSensorAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace IoTSensorAPI.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Report> Reports { get; set; }

        public AppDbContext(DbContextOptions options) : base(options) { }
    }
}
