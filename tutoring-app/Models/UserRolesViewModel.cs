﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tutoring_app.Models
{
    /// <summary>
    /// View model for user roles
    /// </summary>
    public class UserRolesViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }

        public string DisplayRoles()
        {
            string result = "";
            for (int i = 0; i < Roles.Count() - 1; i++)
            {
                result += Roles.ElementAt(i) + ", ";
            }
            return result + Roles.ElementAt(Roles.Count() - 1);
        }
    }
}