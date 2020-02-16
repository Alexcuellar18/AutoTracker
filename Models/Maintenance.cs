using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTracker.Models
{
    public class Maintenance
    {
        public int ID { get; set; }
        public Car Car { get; set; }
        public int CarID { get; set; }
        public MaintenanceType MaintenanceType { get; set; }
        public int MaintenanceTypeID { get; set; }
        public int MaintenacePerformedMiles  { get; set; }
        public DateTime MaintenancePerformedDate { get; set; }
        public double MaintenanceCost { get; set; }
        public int MaintenaceFutureMiles { get; set; }
        public int MaintenaceFutureDate { get; set; }
        

        public Maintenance() { }
        public Maintenance(MaintenanceType maintenanceType, int maintenancePerformedMiles, 
            double maintenanceCost , int maintenaceFutureMiles, int maintenaceFutureDate)
        {
            MaintenancePerformedDate = DateTime.Now;
            MaintenanceType = maintenanceType;
            MaintenacePerformedMiles = maintenancePerformedMiles;
            MaintenanceCost = maintenanceCost;
            MaintenaceFutureMiles = maintenaceFutureMiles;
            MaintenaceFutureDate = maintenaceFutureDate;


        }

    }
}
