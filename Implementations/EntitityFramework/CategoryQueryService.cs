using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.HttpParams;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.ServiceContracts;
using Asseco.REST.Contracts.Generics;

namespace projekat.Implementations.EntitityFramework
{
    public class CategoryQueryService : IPersonalFinanceManagementAPICategoriesQueryService
    {
        public Task<Result<CategoryList>> CategoriesGetListAsync(CategoriesGetListHttpParams categoriesGetListHttpParams)
        {
            throw new NotImplementedException();
        }
    }
}
