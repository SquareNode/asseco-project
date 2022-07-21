using projekat.Database.Repository;
using projekat.Models;

namespace projekat.Services {
    public class TransactionService : ITransactionService
    {
        private ITransactionsRepository _repo;

        public TransactionService(ITransactionsRepository repo){
            _repo = repo;
        }
        public Task<Transaction> importTx()
        {
            return Task.FromResult(new Transaction{
                Id = "66229487",
                BeneficiaryName = "Faculty of contemporary arts",
                Date = "1/1/2021",
                Direction = "d",
                Amount = 187.20,
                Description = "Tuition",
                Currency = "USD",
                Mcc = "8299",
                Kind = "pmt"

            });
        }

        public Task<Transaction> getTransactions() {

            return Task.FromResult(new Transaction{
                Id = "66229487",
                BeneficiaryName = "Faculty of contemporary arts",
                Date = "1/1/2021",
                Direction = "d",
                Amount = 187.20,
                Description = "Tuition",
                Currency = "USD",
                Mcc = "8299",
                Kind = "pmt"

            });
        }

        public Task<Transaction> categorizeTransaction()
        {
            return Task.FromResult(new Transaction{
                Id = "66229487",
                BeneficiaryName = "Faculty of contemporary arts",
                Date = "1/1/2021",
                Direction = "d",
                Amount = 187.20,
                Description = "Tuition",
                Currency = "USD",
                Mcc = "8299",
                Kind = "pmt"

            });
        }

        public Task<Transaction> splitTransaction()
        {
            return Task.FromResult(new Transaction{
                Id = "66229487",
                BeneficiaryName = "Faculty of contemporary arts",
                Date = "1/1/2021",
                Direction = "d",
                Amount = 187.20,
                Description = "Tuition",
                Currency = "USD",
                Mcc = "8299",
                Kind = "pmt"

            });
        }
    }
}