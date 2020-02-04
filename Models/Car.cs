using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTracker.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string VinNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Millage { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public Car(int aId, string aVinNumber, string aMake, string aModel, int aYear, int aMillage)
        {
            Id = aId;
            VinNumber = aVinNumber;
            Make = aMake;
            Model = aModel;
            Year = aYear;
            Millage = aMillage;
        }

        public Car()
        {

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
