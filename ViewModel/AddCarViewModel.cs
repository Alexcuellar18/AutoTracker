using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTracker.ViewModel
{
    public class AddCarViewModel
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int year { get; set; }
        public int CategoryID { get; set; }
        public List<SelectListItem> Categories { get; set; }

        public AddCarViewModel()
        { }
    }
}
