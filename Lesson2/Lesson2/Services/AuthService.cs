using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson2.Services
{
    public class AuthService
    {
        Regex nsRegex = new("[A-Za-z]");
        Regex usernameRegex = new("[A-Za-z0-9_.]");

        public bool CheckRegistration(User user)
        {
            if (nsRegex.IsMatch(user.Name) && nsRegex.IsMatch(user.Surname) && usernameRegex.IsMatch(user.Username))
            {
                return true;
            }
            return false;
        }
    }
}
