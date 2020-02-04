using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoTracker.Models;
using AutoTracker.ViewModels;

namespace AutoTracker.Controllers
{
    public class UserController : Controller
    {
        static private List<string> Users = new List<string>();
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
                return Redirect("/Home/HomePage");//if user is validated send to page after login
            }
            else
            {
                return View();
            }

        }

        private static string Validate(User user, string verify)
        {

            string answer =  null;
            if (user.Password != null || verify != null)
            {
                if (user.Password != verify)
                {

                    answer = ("The password cannot be verified");
                };
            }
            else
            {
                answer = "Password and verification need to be valid";
            }
            return answer;
        }
    }
}