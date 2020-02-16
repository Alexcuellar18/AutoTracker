
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoTracker.Models;
using AutoTracker.ViewModels;
using AutoTracker.Data;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace AutoTracker.Controllers
{
    public class UserController : Controller
    {
        private AutoTrackerDbContext context;
        public UserController(AutoTrackerDbContext dbContext)
        {
            context = dbContext;
        }

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
                User newUser = new User()
                {
                    Name = addUserViewModel.Name,
                    LastName = addUserViewModel.LastName,
                    Username = addUserViewModel.Username,
                    Password = addUserViewModel.Password,
                    ZipCode = addUserViewModel.ZipCode,
                    Email = addUserViewModel.Email,
                    PhoneNumber = addUserViewModel.PhoneNumber
                    
                };
                context.Users.Add(newUser);
                context.SaveChanges();
                HttpContext.Session.SetInt32("userID", newUser.ID);
                    

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
                User theUser = context.Users.Where(x => x.Username == logUserViewModel.Username
                                                && x.Password == logUserViewModel.Password).FirstOrDefault();
                if (theUser !=null)
                {
                    HttpContext.Session.SetInt32("userID", theUser.ID);
                    return Redirect("/Home/MainPage");
                }
                else
                {
                    ViewBag.errors = "The username or password DO NOT exist, please try again";
                    return View("../Home/Index", logUserViewModel);
                }
 
            }
            else
            {
                return View("../Home/Index", logUserViewModel);
            }
        }

        

    }
}