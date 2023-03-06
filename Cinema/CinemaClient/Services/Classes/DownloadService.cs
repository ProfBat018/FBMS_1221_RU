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
        // https://www.omdbapi.com/?s=batman&apikey=fdacdf88
        public string DownloadJson(string search)
        {
            WebClient client = new();

            return String.Empty;
        }
    }
}
