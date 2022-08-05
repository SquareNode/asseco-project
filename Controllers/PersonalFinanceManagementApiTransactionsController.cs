using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.HttpParams;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.ServiceContracts;
using Asseco.Contracts;
using Asseco.Contracts.Abstractions;
using Asseco.Contracts.Common;
using Asseco.Contracts.Errors;
using Asseco.REST.Binding;
using Asseco.REST.Starter;
using Asseco.REST.Validations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using ValidationProblem = Asseco.Contracts.Errors.ValidationError;
using projekat;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Controller.V1
{
	[ValidateModel]
	public partial class PersonalFinanceManagementAPITransactionsController : InvocationContextBaseController
	{
		
		private readonly IPersonalFinanceManagementAPITransactionsQueryService _personalFinanceManagementAPITransactionsQueryService; 

		private readonly IPersonalFinanceManagementAPITransactionsCommandService _personalFinanceManagementAPITransactionsCommandService; 

		public PersonalFinanceManagementAPITransactionsController(IPersonalFinanceManagementAPITransactionsQueryService personalFinanceManagementAPITransactionsQueryService
		, IPersonalFinanceManagementAPITransactionsCommandService personalFinanceManagementAPITransactionsCommandService)
		{
					_personalFinanceManagementAPITransactionsQueryService = personalFinanceManagementAPITransactionsQueryService;
					_personalFinanceManagementAPITransactionsCommandService = personalFinanceManagementAPITransactionsCommandService;
		}

	  
		[HttpGet]
		[Route("/transactions", Name = "Transactions_GetList")]
		[Consumes("application/json")]
		[ProducesResponseType(typeof(TransactionPagedList), 200)]
		[ProducesResponseType(typeof(ValidationProblem), 400)]
		public async System.Threading.Tasks.Task<IActionResult> TransactionsGetList ([ModelBinder(typeof(HttpParametersModelBinder))] TransactionsGetListHttpParams transactionsGetListHttpParams) 
		{
			var res = await _personalFinanceManagementAPITransactionsQueryService.TransactionsGetListAsync(transactionsGetListHttpParams);
			return res;
		}

	  
		[HttpPost]
		[Route("/transactions/import", Name = "Transactions_Import")]
		[ProducesResponseType(typeof(IActionResult), 200)]
		[ProducesResponseType(typeof(BusinessProblem), 440)]
		[ProducesResponseType(typeof(ValidationProblem), 400)]
		public async System.Threading.Tasks.Task<IActionResult> TransactionsImport ([FromForm] IFormFile file)
		{
			
			return await _personalFinanceManagementAPITransactionsCommandService.TransactionsImportAsync(file);
		}

	  
		[HttpPost]
		[Route("/transaction/{id}/split", Name = "Transactions_Split")]
		[Consumes("application/json")]
		[ProducesResponseType(typeof(IActionResult), 200)]
		[ProducesResponseType(typeof(BusinessProblem), 440)]
		[ProducesResponseType(typeof(ValidationProblem), 400)]
		public async System.Threading.Tasks.Task<IActionResult> TransactionsSplit ([ModelBinder(typeof(HttpParametersModelBinder))] TransactionsSplitHttpParams transactionsSplitHttpParams,
		 [FromBody] SplitTransactionCommand splitTransactionCommand) 
		{
			return await _personalFinanceManagementAPITransactionsCommandService.TransactionsSplitAsync(transactionsSplitHttpParams, splitTransactionCommand);
		}

	  
		[HttpPost]
		[Route("/transaction/{id}/categorize", Name = "Transactions_Categorize")]
		[Consumes("application/json")]
		[ProducesResponseType(typeof(IActionResult), 200)]
		[ProducesResponseType(typeof(BusinessProblem), 440)]
		[ProducesResponseType(typeof(ValidationProblem), 400)]
		public async System.Threading.Tasks.Task<IActionResult> TransactionsCategorize ([ModelBinder(typeof(HttpParametersModelBinder))] TransactionsCategorizeHttpParams transactionsCategorizeHttpParams,
		 [FromBody] TransactionCategorizeCommand transactionCategorizeCommand) 
		{
			return await _personalFinanceManagementAPITransactionsCommandService.TransactionsCategorizeAsync(transactionsCategorizeHttpParams, transactionCategorizeCommand);
		}

	  
		[HttpPost]
		[Route("/transaction/auto-categorize", Name = "Transactions_AutoCategorize")]
		[Consumes("application/json")]
		[ProducesResponseType(typeof(IActionResult), 200)]
		[ProducesResponseType(typeof(ValidationProblem), 400)]
		public async System.Threading.Tasks.Task<IActionResult> TransactionsAutoCategorize ([ModelBinder(typeof(HttpParametersModelBinder))] TransactionsAutoCategorizeHttpParams transactionsAutoCategorizeHttpParams
		) 
		{
			return await _personalFinanceManagementAPITransactionsCommandService.TransactionsAutoCategorizeAsync(transactionsAutoCategorizeHttpParams);
		}

	}
}