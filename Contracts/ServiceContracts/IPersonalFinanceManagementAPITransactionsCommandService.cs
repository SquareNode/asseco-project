using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.HttpParams;
using Asseco.Contracts;
using Asseco.Contracts.Common;
using Asseco.Contracts.Errors;
using Asseco.REST.Clients.Abstractions.Models.Content;
using Asseco.REST.Contracts.Generics;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using Microsoft.AspNetCore.Mvc;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.ServiceContracts
{
	[ServiceContract]
	public interface IPersonalFinanceManagementAPITransactionsCommandService
	{	
		System.Threading.Tasks.Task<Result<TransactionPagedList>> TransactionsImportAsync (IFormFile file);
		System.Threading.Tasks.Task<Result<TransactionPagedList>> TransactionsSplitAsync (TransactionsSplitHttpParams transactionsSplitHttpParams, SplitTransactionCommand splitTransactionCommand );
		System.Threading.Tasks.Task<Result<TransactionPagedList>> TransactionsCategorizeAsync (TransactionsCategorizeHttpParams transactionsCategorizeHttpParams, TransactionCategorizeCommand transactionCategorizeCommand );
		System.Threading.Tasks.Task<Result<TransactionPagedList>> TransactionsAutoCategorizeAsync (TransactionsAutoCategorizeHttpParams transactionsAutoCategorizeHttpParams);
	}
}