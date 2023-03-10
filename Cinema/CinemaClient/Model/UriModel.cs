using MaterialDesignColors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClient.Model
{
    class UriModel
    {
        private static readonly string _apiKey = "fdacdf88";
        private static readonly string _link = "https://www.omdbapi.com/?";
    
        public static string SearchByMovie(string search)
        {
            return $"{_link}s={search}&apikey={_apiKey}";
        }

        public static string SearchById(string imdbId)
        {
            return $"{_link}i={imdbId}&plot=full&apikey={_apiKey}";
        }

    }
}
