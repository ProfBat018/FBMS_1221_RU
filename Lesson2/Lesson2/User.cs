using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Printing;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public enum Gender
    {
        Female = 0,
        Male = 1
    };

    public enum Role
    {
        Teacher = 0,
        Student = 1
    };

    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        private int age;
        public int Age 
        { 
            get => age; 
            set
            {
                if (value > 0 && value <= 110)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Invalid age...");
                }
            }
        }

        public Gender Gender { get; set; }
        public Role Role { get; set; }
        public string Username { get; set; }
        public SecureString Password { get; set; }
    }
}
