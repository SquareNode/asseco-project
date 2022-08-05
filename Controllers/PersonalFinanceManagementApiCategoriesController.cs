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
    public partial class PersonalFinanceManagementAPICategoriesController : InvocationContextBaseController
    {

        private readonly IPersonalFinanceManagementAPICategoriesQueryService _personalFinanceManagementAPICategoriesQueryService;

        private readonly IPersonalFinanceManagementAPICategoriesCommandService _personalFinanceManagementAPICategoriesCommandService;

        public PersonalFinanceManagementAPICategoriesController(IPersonalFinanceManagementAPICategoriesQueryService personalFinanceManagementAPICategoriesQueryService, IPersonalFinanceManagementAPICategoriesCommandService personalFinanceManagementAPICategoriesCommandService)
        {
            _personalFinanceManagementAPICategoriesQueryService = personalFinanceManagementAPICategoriesQueryService;
            _personalFinanceManagementAPICategoriesCommandService = personalFinanceManagementAPICategoriesCommandService;
        }


        [HttpPost]
        [Route("/categories/import", Name = "Category_Improt")]
        [ProducesResponseType(typeof(IActionResult), 200)]
        [ProducesResponseType(typeof(BusinessProblem), 440)]
        [ProducesResponseType(typeof(ValidationProblem), 400)]
        public async System.Threading.Tasks.Task<IActionResult> CategoryImprot([FromForm] IFormFile file)
        {
            return await _personalFinanceManagementAPICategoriesCommandService.CategoryImprotAsync(file);
        }


        [HttpGet]
        [Route("/categories", Name = "Categories_GetList")]
        [Consumes("application/json")]
        [ProducesResponseType(typeof(CategoryList), 200)]
        [ProducesResponseType(typeof(ValidationProblem), 400)]
        public async System.Threading.Tasks.Task<IActionResult> CategoriesGetList([ModelBinder(typeof(HttpParametersModelBinder))] CategoriesGetListHttpParams categoriesGetListHttpParams
        )
        {
            return await _personalFinanceManagementAPICategoriesQueryService.CategoriesGetListAsync(categoriesGetListHttpParams);
        }

    }
}