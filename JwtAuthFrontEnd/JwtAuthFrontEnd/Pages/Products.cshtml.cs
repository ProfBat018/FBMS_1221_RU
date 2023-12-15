using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace JwtAuthFrontEnd.Pages
{
    public class ProductsModel : PageModel
    {
        public string[] Products { get; set; }
        public void OnGet()
        {
        }

        public async Task OnPost()
        {
            HttpClient client = new();
            HttpRequestMessage request = new();

            request.Method = HttpMethod.Get;
            request.RequestUri = new Uri("https://localhost:7108/api/products2");

            request.Headers.Add("Authorization", HttpContext.Session.GetString("Authorization"));

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string products = await response.Content.ReadAsStringAsync();

                Products = JsonSerializer.Deserialize < string[]>(products);
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password");
            }
        }
    }
}
