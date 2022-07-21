using projekat.Database.Entities;

namespace projekat.Database.Repository {
    public interface ITransactionsRepository {
        Task<TransactionEntity> add(TransactionEntity t);
        Task<TransactionEntity> get();
    }
}