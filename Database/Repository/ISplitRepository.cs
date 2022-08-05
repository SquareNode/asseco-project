using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
using projekat.Database.Entities;
using static projekat.Database.Repository.SplitRepository;

namespace projekat.Database.Repository
{
    public interface ISplitRepository
    {
        Task<SplitEntity> add(SplitEntity t);

        Task<List<SingleCategorySplit>> split(string id, List<SingleCategorySplit> splits);
    }
}
