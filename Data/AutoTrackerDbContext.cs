using AutoTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoTracker.Data
{
    public class AutoTrackerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<MaintenanceType> MaintenanceTypes { get; set; }
        public DbSet<Mod> Mods { get; set; }

        // public DbSet<Maintenance> Maintenances { get; set; }

        public AutoTrackerDbContext(DbContextOptions<AutoTrackerDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}