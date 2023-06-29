namespace BlazorEcomm.Client.Pages
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;

    public partial class CategoryDetail
    {
        protected const string RelativePath = "category/{url}";

        private Category? _category = null;

        private List<Category> categories = new List<Category>();

        private string message = string.Empty;

        [Inject]
        private ICategoryService? _categoryService { get; set; }

        [Parameter]
        public int url { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            message = "Loading category...";
        }
    }
}
