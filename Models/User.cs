﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoTracker.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    
        public int ZipCode { get; set; }
        public int PhoneNumber { get; set; }

        public User() { }
        public User (string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }


    }
}
