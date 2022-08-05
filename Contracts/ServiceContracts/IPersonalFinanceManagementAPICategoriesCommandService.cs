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
	public interface IPersonalFinanceManagementAPICategoriesCommandService
	{	
		System.Threading.Tasks.Task<Result<CategoryList>> CategoryImprotAsync (IFormFile file);
	}
}