using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;
using System.Text.Json;

namespace JwtAuthFrontEnd.Pages
{
    public class TokenResponse
    {
        public string token { get; set; }
        public string refreshToken { get; set; }
        public string validTo { get; set; }
    }

    public class LoginModel : PageModel
    {
        public void OnGet()
        {

        }

        public async Task OnPost(string email, string password)
        {
            HttpClient client = new();
            HttpRequestMessage request = new();

            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri("https://localhost:7108/Login");

            var data = JsonSerializer.Serialize(new { email, password });

            request.Content = new StringContent(
                data,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string token = await response.Content.ReadAsStringAsync();

                TokenResponse tokenResponse = JsonSerializer.Deserialize<TokenResponse>(token);

                HttpContext.Session.SetString("Authorization", $"Bearer {tokenResponse.token}");

                Response.Redirect("/Success");
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password");
            }

        }
    }
}
