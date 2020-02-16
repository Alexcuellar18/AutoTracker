using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTracker.Models
{
    public class Car
    {
        public int ID { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
        public string VinNumber { get; }
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public int CurrentMiles { get; set; }
        public int NextMaintenanceMiles { get; set; }
        public int NextMaintenanceDays { get; set; }

        public Car() { }
        public Car(string aVinNumber, string aMake, String aModel, 
            int aYear, int aCurrentMiles, int aNextMaintenanceMiles, int aNextMaintenanceDays)
        {
            VinNumber = aVinNumber;
            Make = aMake;
            Model = aModel;
            Year = aYear;
            CurrentMiles = aCurrentMiles;
            NextMaintenanceMiles = aNextMaintenanceMiles;
            NextMaintenanceDays = aNextMaintenanceDays;


        }
         
        void Services()
        {
            Console.WriteLine("function for automobile's services will go here");
        }
        void Performance()
        {
            Console.WriteLine("Function for automobile performance will go here");
        }
    }
}
