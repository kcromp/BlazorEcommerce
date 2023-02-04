using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient HttpClient;

        public ProductService(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public async Task GetProductsAsync()
        {
            var result = await HttpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }
        }
    }
}
