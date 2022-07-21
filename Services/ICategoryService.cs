using projekat.Models;

namespace projekat.Services {
    public interface ICategoryService {

        public Task<Category> importCategories();
    }
}