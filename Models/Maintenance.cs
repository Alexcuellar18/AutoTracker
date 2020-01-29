using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace AutoTracker.Models
{
    public class Maintenance
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public DateTime Date { get; set; }
        public static bool IsDataLoaded = false;

        // loading and parsing data from  maintenance_items.csv
        private static void LoadData()
        {
            if (IsDataLoaded)
            {
                return;
            }
            List<string[]> rows = new List<string[]>();

            // read the file and then closes the file
            using (StreamReader readFile = File.OpenText("Models/maintenance_items.csv"))
            {
                while (reader.Peek() >= 0)
                {
                    string line;
                    while (line =readFile.ReadLine() != null)
                    {
                        rows.Add(line);
                    }
                    
                }
                

                
            }

            // Split every row of maintenance_item.csv file into a string array
            private static string[] rowFile (string row, char cellSeparatior = '/t')
            {
                StringBuilder valueBuilder = new StringBuilder();
                foreach (char character in row)
                {
                    if (character==cellSeparatior)
                    {

                    }
                }
            }


        }



    }
}
