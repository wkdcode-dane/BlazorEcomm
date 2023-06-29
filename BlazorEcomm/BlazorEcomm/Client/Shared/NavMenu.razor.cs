namespace BlazorEcomm.Client.Shared
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;

    public partial class NavMenu
    {
        [Inject]
        private ICategoryService? _categoryService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (_categoryService != null)
                await _categoryService.GetCategories();
        }
    }
}
