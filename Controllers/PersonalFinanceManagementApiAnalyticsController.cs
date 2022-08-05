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

namespace Asseco.Rest.PersonalFinanceManagementAPI.Controller.V1
{
    [ValidateModel]
    //[Authorize]
    public partial class PersonalFinanceManagementAPIAnalyticsController : InvocationContextBaseController
    {

        private readonly IPersonalFinanceManagementAPIAnalyticsQueryService _personalFinanceManagementAPIAnalyticsQueryService;


        public PersonalFinanceManagementAPIAnalyticsController(IPersonalFinanceManagementAPIAnalyticsQueryService personalFinanceManagementAPIAnalyticsQueryService)
        {
            _personalFinanceManagementAPIAnalyticsQueryService = personalFinanceManagementAPIAnalyticsQueryService;

        }


        [HttpGet]
        [Route("/spending-analytics", Name = "Spendings_Get")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(SpendingsByCategory), 200)]
        [ProducesResponseType(typeof(ValidationProblem), 400)]
        public async System.Threading.Tasks.Task<IActionResult> SpendingsGet([ModelBinder(typeof(HttpParametersModelBinder))] SpendingsGetHttpParams spendingsGetHttpParams)
        {

            return await _personalFinanceManagementAPIAnalyticsQueryService.SpendingsGetAsync(spendingsGetHttpParams);
        }

    }
}