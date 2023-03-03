using CinemaClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClient.Services.Interfaces
{
    public interface IUserManageService
    {
        void Add(User user);
        User GetUser(string username, string password);
        bool CheckExists(string username, string password);
    }
}
