using Cosmos.Models;
using Cosmos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cosmos.Pages
{
    public class AddProductsModel : PageModel
    {
        private readonly ICosmosService _cosmosService;

        public IEnumerable<Product>? Products { get; set; }

        public AddProductsModel(ICosmosService cosmosService)
        {
            _cosmosService = cosmosService;
        }

        public async Task OnGet()
        {
            await _cosmosService.PushActiveProductsAsync();
        }
    }
}
