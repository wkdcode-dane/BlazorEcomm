namespace BlazorEcomm.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategoriesAsync();
        Task<ServiceResponse<Category>> GetCategoryByIdAsync(int categoryId);
        
        Task<ServiceResponse<List<Product>>> GetCategoryBySlugAsync(string slug);
    }
}
