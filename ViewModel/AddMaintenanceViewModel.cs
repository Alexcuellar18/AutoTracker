using AutoTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTracker.ViewModel
{
    public class AddMaintenanceViewModel
    {
        public string MaintenanceName { get; set; }
        public double MaintenanceDescription { get; set; }
        public int MilesInterval { get; set; }
        public DateTime TimeInterval { get; set; }

        public List<Maintenance> Maintenances = new List<Maintenance>();

        public AddMaintenanceViewModel()
        {

        }


    }
}
