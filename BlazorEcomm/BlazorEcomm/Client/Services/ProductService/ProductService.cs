namespace BlazorEcomm.Client.Services.ProductService
{
    using BlazorEcomm.Shared;
    using Microsoft.AspNetCore.Components;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Threading.Tasks;

    public class ProductService : IProductService
    {

        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();

        public Product Product { get; set; } = new Product();

        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/products");

            if (result != null && result.Data != null)
                Products = result.Data;
        }

        public async Task <ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/products/{productId}");

            return result;
        }
    }
}
