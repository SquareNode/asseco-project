using Asseco.Contracts;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.HttpParams;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.ServiceContracts;
using Asseco.REST.Contracts.Generics;

using System.Net;
using Microsoft.AspNetCore.Mvc;
using projekat.Database.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Asseco.Rest.PersonalFinanceManagementAPI.Implementations.EntityFramework
{


    public class PersonalFinanceManagementApiQueryServiceTransactionEntityFramework : IPersonalFinanceManagementAPITransactionsQueryService
    {
        private readonly ITransactionsRepository repo;
        private readonly IMapper mapper;

        public PersonalFinanceManagementApiQueryServiceTransactionEntityFramework(ITransactionsRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public async Task<Result<TransactionPagedList>> TransactionsGetListAsync(TransactionsGetListHttpParams transactionsGetListHttpParams)
        {

            var result = repo.get();
           

            var transactionWithSplitsList = new List<TransactionWithSplits>();

            //kind filter

            if (!string.IsNullOrEmpty(transactionsGetListHttpParams.TransactionKind))
            {
                result = result.Where(p => p.kind == transactionsGetListHttpParams.TransactionKind);
            }

            if (transactionsGetListHttpParams.EndDate != null)
            {
                result = result.Where(p => p.date.ToUniversalTime() <= transactionsGetListHttpParams.EndDate.Value.ToUniversalTime());
            }

            if (transactionsGetListHttpParams.StartDate != null)
            {
                result = result.Where(p => p.date.ToUniversalTime() >= transactionsGetListHttpParams.StartDate.Value.ToUniversalTime());
            }

            var totalNumTx = result.Count();

            result = result.Skip((transactionsGetListHttpParams.PageNumber - 1) * transactionsGetListHttpParams.PageSize).Take(transactionsGetListHttpParams.PageSize);

            if (transactionsGetListHttpParams.SortOrder != null && transactionsGetListHttpParams.SortType != null)
            {
                if (transactionsGetListHttpParams.SortOrder == "asc")
                {
                    result = result.OrderBySort(transactionsGetListHttpParams.SortType);
                }
                else if (transactionsGetListHttpParams.SortOrder == "desc")
                    result = result.OrderByDescendingSort(transactionsGetListHttpParams.SortType);
            }



            var res = await result.ToListAsync();

            foreach (var x in res)
            {
                transactionWithSplitsList.Add(mapper.Map<TransactionWithSplits>(x));
            }


            var list = new TransactionPagedList
                {
                    Items = transactionWithSplitsList,
                    PageSize = transactionsGetListHttpParams.PageSize,
                    TotalCount = totalNumTx,
                    Page = transactionsGetListHttpParams.PageNumber,
                    SortOrder = transactionsGetListHttpParams.SortOrder,
                    SortBy = transactionsGetListHttpParams.SortType,
                    TotalPages = (int)Math.Ceiling((double)totalNumTx / (double)transactionsGetListHttpParams.PageSize)
                };


            return await Task.FromResult(new Result<TransactionPagedList>()
            {
                StatusCodeResponse = new OkObjectResult(list),
                StatusCode = (int)HttpStatusCode.OK,
                Response = list
                     
            });


            }
        }

    public static class IQueryableExtensions
    {
        public static IOrderedQueryable<T> OrderBySort<T>(this IQueryable<T> source, string propertyName)
        {
            return source.OrderBy(ToLambda<T>(propertyName));
        }

        public static IOrderedQueryable<T> OrderByDescendingSort<T>(this IQueryable<T> source, string propertyName)
        {
            return source.OrderByDescending(ToLambda<T>(propertyName));
        }

        private static Expression<Func<T, object>> ToLambda<T>(string propertyName)
        {
            var parameter = Expression.Parameter(typeof(T));
            var property = Expression.Property(parameter, propertyName);
            var propAsObject = Expression.Convert(property, typeof(object));

            return Expression.Lambda<Func<T, object>>(propAsObject, parameter);
        }
    }


}