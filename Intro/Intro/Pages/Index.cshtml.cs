using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Intro.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Movie Movie { get; set; } = new();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var service = new MovieDownloadService();

            var movieName = Request.Form["movieName"];
            var movieData = service.GetMovieData(movieName);
            
            Movie = JsonSerializer.Deserialize<Movie>(movieData.Result);

            TempData["totalPages"] = Movie.TotalPages;
            
            HttpContext.Session.SetString("movieName", movieName);
        }
        
        
        public void OnPostNext()
        {
            var service = new MovieDownloadService();
            
            var pageValue = Request.Form["pageBtn"];

            var movieData = service.GetMovieData(HttpContext.Session.GetString("movieName"), pageValue);
            
            Movie = JsonSerializer.Deserialize<Movie>(movieData.Result);
            
            TempData["totalPages"] = Movie.TotalPages;
        }
    }
}