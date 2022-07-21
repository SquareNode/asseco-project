using projekat.Database.Entities;

namespace projekat.Database.Repository {
    public class TransactionRepository : ITransactionsRepository{
        private readonly TransactionDBContext _dbcontext;

        public TransactionRepository(TransactionDBContext context ) {
            _dbcontext = context;
        }
        public async Task<TransactionEntity> add(TransactionEntity t)
        {
            _dbcontext.Transactions.Add(t);

            await _dbcontext.SaveChangesAsync();

            return t;
        }

        public async Task<TransactionEntity> get()
        {
            // return await _dbcontext.Transactions;
            return null;
        }
    
    }
}