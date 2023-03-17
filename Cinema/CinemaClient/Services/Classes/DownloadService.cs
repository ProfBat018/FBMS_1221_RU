﻿using CinemaClient.Services.Interfaces;
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
        public string DownloadJson(string url)
        {
            WebClient client = new();
            try
            {
                var res = client.DownloadString(url);
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}