namespace BlazorEcomm.Client.Services.ProductService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }
        Task GetCategories();
        Task<ServiceResponse<Category>> GetCategoryById(int categoryId);
    }
}
