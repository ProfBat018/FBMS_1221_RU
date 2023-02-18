using System;
using System.Collections.Generic;
using System.Linq;
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
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public Role Role { get; set; }
        public string Username { get; set; }
        public SecureString Password { get; set; }
    }
}
