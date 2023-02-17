using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using WpfIntro.Model;
using WpfIntro.Services.Interfaces;

namespace WpfIntro.Services.Classes
{
    internal class SearchService : ISearchService // SearchService - superclass
    {
        private readonly string _link = @"https://www.omdbapi.com/";
        private readonly string _apiKey = "2af856c7";

        public IDeserializeService DeserializeService { get; init; } // Dip realization
        public IDataDownloadService DataDownloadService { get; init; }

        public SearchService() { }
        public SearchService(IDeserializeService deserializeService, IDataDownloadService dataDownloadService)
        {
            DeserializeService = deserializeService;
            DataDownloadService = dataDownloadService;
        }

        public T Search<T>(string? title)
        {
            Regex re = new("[A-Za-z]");

            if (title != null && re.IsMatch(title))
            {
                try
                {
                    string uri = $"{_link}?apikey={_apiKey}&s={title}";

                    var json = DataDownloadService.DownloadJson(uri);

                    var result = DeserializeService.Deserialize<T>(json);

                    return result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Enter valid title", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                throw new NullReferenceException("Title is null or wrong");
            }
        }
    }
}
