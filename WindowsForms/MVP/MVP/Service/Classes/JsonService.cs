using MVP.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MVP.Service.Classes 
{
    internal class JsonService : IJsonService
    {
        private WebClient client = new();

        private readonly string _apiKey = @"2af856c7";
        private readonly string _link = @"https://www.omdbapi.com/";

        public string? GetJsonByTitle(string title)
        {
                try
                {
                    var url = $"{_link}?apikey={_apiKey}&s={title}";

                    var res = client.DownloadString(url);

                    return res;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    client.Dispose();
                }
        }
    }
}
