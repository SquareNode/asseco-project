using projekat.Models;

namespace projekat.Services {
    public class CategoryService : ICategoryService
    {
        public Task<Category> importCategories()
        {
            return Task.FromResult(new Category{
                Code = "123",
                Name = "abc",
                ParentCode = "aaa"

            });
        }
    }
}