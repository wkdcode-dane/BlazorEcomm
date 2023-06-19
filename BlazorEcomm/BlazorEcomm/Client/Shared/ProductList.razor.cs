namespace BlazorEcomm.Client.Shared
{
    using BlazorEcomm.Shared;
    using Microsoft.AspNetCore.Components;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Threading.Tasks;

    public partial class ProductList
    {
        [Inject]
        HttpClient Http { get; set; } = new HttpClient();

        private static List<Product> Products = new();

        protected override async Task OnInitializedAsync()
        {
            var result = await Http.GetFromJsonAsync<List<Product>>("api/products");

            if (result != null)
                Products = result;
        }
    }
}
