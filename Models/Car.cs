using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTracker.Models
{
    public class Car
    {
        private string v;
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;
        private int v6;
        private object ;

        private object 1;

        private object ;

        public string VinNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Millage { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public Car(string aVinNumber, string aMake, string aModel, int aYear, int aMillage)
        {
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
