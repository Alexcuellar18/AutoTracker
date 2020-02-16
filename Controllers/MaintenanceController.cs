using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoTracker.Models;

namespace AutoTracker.Controllers
{
    public class MaintenanceController : Controller
    {

        public List<Maintenance> Maintenances = new List<Maintenance>();
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Add()



    }
}