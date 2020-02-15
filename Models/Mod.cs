using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTracker.Models
{
    public class Mod
    {
        public int ID { get; set; }
        public Car Car { get; set; }
        public int CarID { get; set; }
        public string ModName { get; set; }
        public string ModDescription { get; set; }
        public DateTime ModDate { get; set; }
        public double ModCost { get; set; }
        
        public Mod() { }
        public Mod(string modName, string modDescription, DateTime modDate, double modCost)
        {
            ModName = modName;
            ModDescription = modDescription;
            ModDate = modDate;
            ModCost = modCost;

        }


    }
}
