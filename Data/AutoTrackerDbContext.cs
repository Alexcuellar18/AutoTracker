using AutoTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoTracker.Data
{
    public class AutoTrackerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
       // public DbSet<Maintenance> Maintenances { get; set; }
      

        public AutoTrackerDbContext(DbContextOptions<AutoTrackerDbContext> options)
            : base(options)
        {
            Database.EnsureCreatedAsync().Wait();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //        .HasKey(c => new { c.CheeseID, c.MenuID });
        //}



    }
}