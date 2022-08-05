using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
using projekat.Database.Entities;

namespace projekat.Database.Repository {
    public interface ITransactionsRepository {
        Task<TransactionEntity> add(TransactionEntity t);
        Task<List<TransactionEntity>> addRange(List<TransactionEntity> t);


        IQueryable<TransactionEntity> get();


        Task<IQueryable<TransactionEntity>> getIQ();

        Task<TransactionEntity> categorizeTx(string id, string catCode);

        //Task<SpendingsByCategory> findAnalytics(string catCode, DateTime startdate, DateTime enddate, string direction);

        Task<TransactionEntity> getById(string id);
    }
}