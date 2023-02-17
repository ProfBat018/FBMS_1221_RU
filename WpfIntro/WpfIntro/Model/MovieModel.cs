using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WpfIntro.Model
{
    public class MovieModel
    {
        public Search[] Search { get; set; }

        [JsonPropertyName("totalResults")]
        public string TotalResults { get; set; }
        public string Response { get; set; }
    }

    public class Search
    {
        public string Title { get; set; }
        public string Year { get; set; }
        
        [JsonPropertyName("imdbID")]
        public string ImdbID { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }

        public override string ToString()
        {
            return $"{Title} {Year}";
        }
    }

}
