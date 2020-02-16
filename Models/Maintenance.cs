using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTracker.Models
{
    public class Maintenance
    {
        public string MaintenanceName{ get; set; }
        public double MaintenanceDescription { get; set; }

        public int MilesInterval { get; set; }

        public DateTime TimeInterval { get; set; }



    }
}
