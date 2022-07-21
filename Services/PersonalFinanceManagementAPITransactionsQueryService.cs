// using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
// using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.ServiceContracts;
// using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.HttpParams;
// using Asseco.Contracts;
// using Asseco.Contracts.Common;
// using Asseco.Contracts.Errors;
// using Asseco.Messaging.Abstractions;
// using Asseco.REST.Clients.Abstractions.Models.Content;
// using Asseco.REST.Contracts.Generics;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using System;
// using System.Collections.Generic;
// using System.ServiceModel;
// using System.Text;

// namespace Asseco.Rest.PersonalFinanceManagementAPI.Services.EF.V1
// {
// 	[ServiceContract]
// 	public class PersonalFinanceManagementAPITransactionsQueryService: IPersonalFinanceManagementAPITransactionsQueryService
// 	{	

// 		private readonly ILogger<PersonalFinanceManagementAPITransactionsQueryService> _logger;

// 		private readonly IBrokerFacade _eventBus;

// 		public PersonalFinanceManagementAPITransactionsQueryService(ILogger<PersonalFinanceManagementAPITransactionsQueryService> logger, IBrokerFacade eventBus)
// 		{
// 			_logger = logger;
// 			_eventBus = eventBus;
// 		}

// 		public Task<Result<TransactionPagedList>> TransactionsGetListAsync (TransactionsGetListHttpParams transactionsGetListHttpParams, Paging paging, Sorting sorting)
// 		{
// 			throw new NotImplementedException();		 
// 		}

// 	}
// }