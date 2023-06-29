namespace BlazorEcomm.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
        {
            var response = new ServiceResponse<List<Category>>
            {
                Data = await _context.Categories.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Category>> GetCategoryByIdAsync(int categoryId)
        {
            var response = new ServiceResponse<Category>();

            var category = await _context.Categories.FindAsync(categoryId);

            if (category == null)
            {
                response.Success = false;
                response.Message = "Sorry, but no category has been found.";
            }
            else
            {
                response.Data = category;
            }

            return response;
        }

/*        public async Task<ServiceResponse<Category>> GetCategoryBySlugAsync(string slug)
        {
            var response = new ServiceResponse<Category>();


            var category = await _context.Categories.FindAsync(slug);

            if (category == null)
            {
                response.Success = false;
                response.Message = "Sorry, but no category has been found.";
            }
            else
            {
                response.Data = category;
            }

            return response;
        }*/
    }
}
