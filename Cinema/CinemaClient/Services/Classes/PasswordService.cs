using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CinemaClient.Services.Classes
{
    class PasswordService
    {
        private readonly string _password;
        private readonly string _confirm;

        public PasswordService(PasswordBox password, PasswordBox confirm)
        {
            _password = password.Password;
            _confirm = confirm.Password;
        }

        public bool IsMatch()
        {
            Regex passRegex = new("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-_]).{8,}$");
            if (passRegex.IsMatch(_confirm))
            {
                if (_password == _confirm)
                {
                    return true;
                }
            }
                return false;
        }
    }
}
