
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoTracker.Models;
using AutoTracker.ViewModels;

namespace AutoTracker.Controllers
{
    public class UserController : Controller
    {
        
        public IActionResult Index()
        {
            
            return View();
        }
        
        //Action GET  where the future user land to register
        public IActionResult Add()
        {
            return View();
            
        }


        //Action POST when the user tries to register
        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/Home/MainPage");//if user is validated send to the  Main Page
            }
            else
            {
                return View();
            }

        }
        
        
        [HttpPost]
        public IActionResult Login(LogUserViewModel logUserViewModel)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/Home/MainPage");
            }
            else
            {
                return View("../Home/Index", logUserViewModel);
            }
        }

        

    }
}