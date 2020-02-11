using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTracker.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string VinNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int CategoryID { get; set; }
        public CarCategory Category { get; set; }
        public IList<CarList> CarLists { get; set; }
       
    }
}
