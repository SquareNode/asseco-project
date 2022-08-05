using Asseco.Contracts;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.HttpParams;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.ServiceContracts;
using Asseco.REST.Contracts.Generics;

using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Implementations.Mock
{


public class PersonalFinanceManagementApiQueryServiceTransactionMock : IPersonalFinanceManagementAPITransactionsQueryService
{
    public Task<Result<TransactionPagedList>> TransactionsGetListAsync(TransactionsGetListHttpParams transactionsGetListHttpParams)
    {   
        var transactionWithSplitsList = new List<TransactionWithSplits>();

        transactionWithSplitsList.Add(new TransactionWithSplits{
            Id = "123",
            BeneficiaryName = "abc",
            Date = "abc",
            Direction = "c"
        });

        var transactionPageListTask = Task.FromResult(new TransactionPagedList {
            Items = transactionWithSplitsList,
            PageSize = 12,
            TotalCount = 12
        });

         var transactionPagedList = new TransactionPagedList {
            Items = transactionWithSplitsList,
            PageSize = 12,
            TotalCount = 12
        };

        return Task.FromResult(new Result<TransactionPagedList>() { StatusCodeResponse = new OkObjectResult(transactionPagedList),
         StatusCode = (int)HttpStatusCode.OK, Response = transactionPagedList });

        
    }
}
	
}