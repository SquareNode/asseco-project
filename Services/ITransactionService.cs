using projekat.Models;

namespace projekat.Services {
    public interface ITransactionService {
        //task<bool>
        public Task<Transaction> importTx();
        public Task<Transaction> getTransactions();
        public Task<Transaction> categorizeTransaction();

        public Task<Transaction> splitTransaction();
    }
}