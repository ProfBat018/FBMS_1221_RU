using CinemaClient.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClient.Services.Classes
{
    public class DownloadService : IDownloadService
    {
        public string DownloadJson(string search)
        {
            WebClient client = new();
            try
            {
                var res = client.DownloadString($"https://www.omdbapi.com/?s={search}&apikey=fdacdf88");
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
