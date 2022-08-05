using projekat.Database.Entities;

namespace projekat.Database.Repository
{
    public interface ICategoryRepository
    {

        Task<List<CategoryEntity>> add(List<CategoryEntity> t);
        Task<List<CategoryEntity>> get();

        Task<CategoryEntity> getByCode(string code);  
    }
}
