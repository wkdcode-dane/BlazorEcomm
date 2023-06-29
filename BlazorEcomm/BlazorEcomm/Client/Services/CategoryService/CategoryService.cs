namespace BlazorEcomm.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public List<Category> Categories { get; set; } = new List<Category>();

        public Category Category { get; set; } = new Category();

        public async Task GetCategories()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/categories");

            if (result != null && result.Data != null)
                Categories = result.Data;
        }

        public async Task<ServiceResponse<Category>> GetCategoryById(int categoryId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Category>>($"api/categories/{categoryId}");

            return result;
        }
    }
}
