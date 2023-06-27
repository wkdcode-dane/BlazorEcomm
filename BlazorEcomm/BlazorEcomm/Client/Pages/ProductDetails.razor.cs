namespace BlazorEcomm.Client.Pages
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;

    public partial class ProductDetails
    {
        protected const string RelativePath = "/product/{id:int}";

        private Product? product = null;

        private string message = string.Empty;

        [Inject]
        private IProductService? _productService { get; set; }

        [Parameter]
        public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            message = "Loading product...";

            var result = await _productService.GetProduct(Id);

            if (!result.Success)
            {
                message = result.Message;
            }
            else
            {
                product = result.Data;
            }

        }
    }
}
