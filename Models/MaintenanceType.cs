using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTracker.Models
{
    public class MaintenanceType
    {
        public int MaintenanceTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MilesInterval { get; set; }
        public int DateIntervalDays { get; set; }

        public MaintenanceType() 
        {
          
        }
        public MaintenanceType(string name, string description, int milesInterval, int dateIntervalDays)
        {
            Name = name;
            Description = description;
            MilesInterval = milesInterval;
            DateIntervalDays = dateIntervalDays;
        }
    }

}
