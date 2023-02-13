using MVP.Model;
using MVP.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MVP.Service.Classes
{
    internal class SearchService : ISearchService
    {
        private readonly IJsonService _jsonService;
        private readonly IDeserializeService _deserializeService;

        public SearchService(IJsonService jsonService, IDeserializeService deserializeService)
        {
            _jsonService = jsonService;
            _deserializeService = deserializeService;
        }


        public MovieModel SearchByTitle(string? title)
        {
            Regex ex = new("[A-Za-z]");

            if (title != null && ex.IsMatch(title))
            {
                try
                {
                    var json = _jsonService.GetJsonByTitle(title);

                    var result = _deserializeService.Deserialize<MovieModel>(json);
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            throw new Exception("Something went wrong...");
        }
    }
}
