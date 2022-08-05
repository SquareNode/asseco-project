using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.HttpParams;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.ServiceContracts;
using AutoMapper;
using projekat.Database.Repository;
using Asseco.REST.Contracts.Generics;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Asseco.Contracts.Errors;

namespace projekat.Implementations.EntitityFramework
{
    public class AnalyticsServiceEF : IPersonalFinanceManagementAPIAnalyticsQueryService
    {
        private readonly ITransactionsRepository trRepo;
        private readonly ICategoryRepository catRepo;
        private readonly ISplitRepository splitRepo;
        private readonly IMapper mapper;

        public AnalyticsServiceEF(ITransactionsRepository trRepo, ICategoryRepository catRepo, IMapper mapper)
        {
            this.trRepo = trRepo;
            this.catRepo = catRepo;
            this.splitRepo = splitRepo;
            this.mapper = mapper;
        }
        public async Task<Result<SpendingsByCategory>> SpendingsGetAsync(SpendingsGetHttpParams spendingsGetHttpParams)
        {
            
            var tx = trRepo.get().Where(p => !string.IsNullOrEmpty(p.catCode)).ToList();
            var cats = catRepo.get();

            if (spendingsGetHttpParams.Catcode != null)
                tx = tx.Where(p => p.catCode == spendingsGetHttpParams.Catcode
                || cats.Result.Where(s => s.ParentCode == spendingsGetHttpParams.Catcode).Select(t => t.Code).Contains(p.catCode))                    
                .ToList();
            if(spendingsGetHttpParams.Direction != null)
                tx = tx.Where(p => p.direction == spendingsGetHttpParams.Direction[0]).ToList();
            if(spendingsGetHttpParams.StartDate != null)
                tx = tx.Where(p => p.date >= spendingsGetHttpParams.StartDate).ToList();
            if (spendingsGetHttpParams.EndDate != null)
                tx = tx.Where(p => p.date <= spendingsGetHttpParams.EndDate).ToList();

            //no categorized tx
            if (tx.Count() == 0)
                return await Task.FromResult(new Result<SpendingsByCategory>()
                {
                    StatusCodeResponse = new NotFoundObjectResult(new ValidationError
                    {
                        Error = "no tx",
                        Tag = "no tx",
                        Message = "no categorized transaction in db"
                    }),
                    StatusCode = (int)HttpStatusCode.BadRequest,
                });


            var spendings = tx.GroupBy(p => p.catCode).Select(p => new SpendingInCategory
            {
                Amount = p.Sum(p => p.amount),
                Catcode = p.Key,
                Count = p.Count()
            }).ToList();


            return await Task.FromResult(new Result<SpendingsByCategory>()
            {
                StatusCodeResponse = new OkObjectResult(spendings),
                StatusCode = (int)HttpStatusCode.OK,
                Response = new SpendingsByCategory
                {
                    Groups = spendings
                }

            });
        }
    }
}
