using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoTracker.Models;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Add(User user, string verify)
        {
            ViewBag.user = user;
            string message = validate(user, verify);
            ViewBag.message = message;
            if (user.Password == verify)
            {
                return View();
            }
            else
                return Redirect("Index");
        }

        private static string validate(User user, string verify)
        {

            string answer = "";
            if (user.Password != null || verify != null)
            {
                if (user.Password == verify)
                {
                    answer = ("Welcome {0}" + user.Username);
                }
                else
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