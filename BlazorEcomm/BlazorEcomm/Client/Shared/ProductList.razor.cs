namespace BlazorEcomm.Client.Shared
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;

    public partial class ProductList
    {
        [Inject]
        private IProductService? _productService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (_productService != null)
                await _productService.GetProducts();
        }
    }
}

