using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTracker.Data
{
    public class CarDbContext : DbContext
    {
        public class DbSet<Car> Cars {get; set; }
        public CarDbContext(DbContextOptions<CarDbContext> options)
            : base(options)
        { }
    }
}
