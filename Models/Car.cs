using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTracker.Models
{
    public class Car
    {
        public string VinNumber { get; }
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public Car(string aVinNumber, string aMake, String aModel, int aYear)
        {
            VinNumber = aVinNumber;
            Make = aMake;
            Model = aModel;
            Year = aYear;
        }
        //need for functionalities
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
