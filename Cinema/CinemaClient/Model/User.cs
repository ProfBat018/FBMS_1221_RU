using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClient.Model
{
    public class User
    {
        public string Username { get; set; } = "Nightcall018";
        public string Password { get; set; }
        public string Confirmation { get; set; }
        public string Email { get; set; } = "elvin.azim01@gmail.com";
        public string PhoneNumber { get; set; } = "3251018";

        public DateTime BirthDate { get; set; } = new DateTime(2001, 11, 16);
        public int SelectedOperator { get; set; } = 3;
    }
}
