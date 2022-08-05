/*using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.HttpParams;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.ServiceContracts;
using Asseco.REST.Contracts.Generics;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace projekat.Implementations.Mock
{
    public class CommandMock : IPersonalFinanceManagementAPITransactionsCommandService
    {
        public Task<Result<TransactionPagedList>> TransactionsAutoCategorizeAsync(TransactionsAutoCategorizeHttpParams transactionsAutoCategorizeHttpParams)
        {
            var transactionWithSplitsList = new List<TransactionWithSplits>();

            transactionWithSplitsList.Add(new TransactionWithSplits
            {
                Id = "123",
                BeneficiaryName = "abc",
                Date = "abc",
                Direction = "c"
            });

            var transactionPageListTask = Task.FromResult(new TransactionPagedList
            {
                Items = transactionWithSplitsList,
                PageSize = 12,
                TotalCount = 12
            });

            var transactionPagedList = new TransactionPagedList
            {
                Items = transactionWithSplitsList,
                PageSize = 12,
                TotalCount = 12
            };

            return Task.FromResult(new Result<TransactionPagedList>()
            {
                StatusCodeResponse = new OkObjectResult(transactionPagedList),
                StatusCode = (int)HttpStatusCode.OK,
                Response = transactionPagedList
            });
        }

        public Task<Result<TransactionPagedList>> TransactionsCategorizeAsync(TransactionsCategorizeHttpParams transactionsCategorizeHttpParams, TransactionCategorizeCommand transactionCategorizeCommand)
        {
            var transactionWithSplitsList = new List<TransactionWithSplits>();

            transactionWithSplitsList.Add(new TransactionWithSplits
            {
                Id = "123",
                BeneficiaryName = "abc",
                Date = "abc",
                Direction = "c"
            });

            var transactionPageListTask = Task.FromResult(new TransactionPagedList
            {
                Items = transactionWithSplitsList,
                PageSize = 12,
                TotalCount = 12
            });

            var transactionPagedList = new TransactionPagedList
            {
                Items = transactionWithSplitsList,
                PageSize = 12,
                TotalCount = 12
            };

            return Task.FromResult(new Result<TransactionPagedList>()
            {
                StatusCodeResponse = new OkObjectResult(transactionPagedList),
                StatusCode = (int)HttpStatusCode.OK,
                Response = transactionPagedList
            });
        }

        public Task<Result<TransactionPagedList>> TransactionsImportAsync(TransactionsImportHttpParams transactionsImportHttpParams, Transaction transaction)
        {
            var transactionWithSplitsList = new List<TransactionWithSplits>();

            transactionWithSplitsList.Add(new TransactionWithSplits
            {
                Id = "123",
                BeneficiaryName = "abc",
                Date = "abc",
                Direction = "c"
            });

            var transactionPageListTask = Task.FromResult(new TransactionPagedList
            {
                Items = transactionWithSplitsList,
                PageSize = 12,
                TotalCount = 12
            });

            var transactionPagedList = new TransactionPagedList
            {
                Items = transactionWithSplitsList,
                PageSize = 12,
                TotalCount = 12
            };

            return Task.FromResult(new Result<TransactionPagedList>()
            {
                StatusCodeResponse = new OkObjectResult(transactionPagedList),
                StatusCode = (int)HttpStatusCode.OK,
                Response = transactionPagedList
            });
        }

        public Task<Result<TransactionPagedList>> TransactionsSplitAsync(TransactionsSplitHttpParams transactionsSplitHttpParams, SplitTransactionCommand splitTransactionCommand)
        {
            var transactionWithSplitsList = new List<TransactionWithSplits>();

            transactionWithSplitsList.Add(new TransactionWithSplits
            {
                Id = "123",
                BeneficiaryName = "abc",
                Date = "abc",
                Direction = "c"
            });

            var transactionPageListTask = Task.FromResult(new TransactionPagedList
            {
                Items = transactionWithSplitsList,
                PageSize = 12,
                TotalCount = 12
            });

            var transactionPagedList = new TransactionPagedList
            {
                Items = transactionWithSplitsList,
                PageSize = 12,
                TotalCount = 12
            };

            return Task.FromResult(new Result<TransactionPagedList>()
            {
                StatusCodeResponse = new OkObjectResult(transactionPagedList),
                StatusCode = (int)HttpStatusCode.OK,
                Response = transactionPagedList
            });
        }
    }
}
*/