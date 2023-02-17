using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using WpfIntro.Services.Interfaces;

namespace WpfIntro.Services.Classes
{
    internal class DataDownloadService : IDataDownloadService
    {
        private readonly WebClient client = new();

        public string DownloadJson(string uri)
        {
            var json = client.DownloadString(uri);

            if (json == null)
            {
                throw new NullReferenceException("Json is null!");
            }
            return json;
        }
    }
}
