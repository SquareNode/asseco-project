using Asseco.Contracts.Errors;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.HttpParams;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.ServiceContracts;
using Asseco.REST.Contracts.Generics;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using projekat.Database.Entities;
using projekat.Database.Repository;
using System.Linq;
using System.Net;

namespace projekat.Implementations.EntitityFramework
{
    public class CategoryService : IPersonalFinanceManagementAPICategoriesCommandService
    {
        private readonly ICategoryRepository repo;
        private readonly IMapper mapper;

        public CategoryService(ICategoryRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }
        public async Task<Result<CategoryList>> CategoryImprotAsync(IFormFile file)
        {
            var stream = file.OpenReadStream();
            StreamReader reader = new StreamReader(stream);

            var lst = new List<Category>();

            string line;
            string[] row;
            reader.ReadLine();

            var errArr = new List<ValidationError>();
            var i = 0;

            while ((line = reader.ReadLine()) != null)
            {
                row = line.Split(',');

                if (row.Length != 3)
                {
                    errArr.Add(new ValidationError
                    {
                        Tag = "line : " + i.ToString(),
                        Message = "wrong number of arguments",
                        Error = "wrong num of args"
                    });
                    continue;
                }

                lst.Add(new Category
                {
                    Code = row[0],
                    ParentCode = row[1],
                    Name = row[2]
                });
                i++;
            }

            var parentsInDb = repo.get().Result.Select(p => p.Code).Distinct();
            var parentsInFile = lst.Where(p => string.IsNullOrEmpty(p.ParentCode)).Select(p => p.Code);

            var missingParent = lst.Where(p => !(parentsInDb.Contains(p.ParentCode) || parentsInFile.Contains(p.ParentCode)
            || string.IsNullOrEmpty(p.ParentCode))).ToList();

            if (errArr.Count > 0)
                return await Task.FromResult(new Result<CategoryList>()
                {
                    StatusCodeResponse = new BadRequestObjectResult(errArr),
                    StatusCode = (int)HttpStatusCode.BadRequest,
                });

            if (missingParent.Count > 0)
            {
                return await Task.FromResult(new Result<CategoryList>()
                {
                    StatusCodeResponse = new BadRequestObjectResult(new ValidationError
                    {
                        Message = "category has no parent",
                        Error = "no parent",
                        Tag = "no parent"
                    }),
                    StatusCode = (int)HttpStatusCode.BadRequest,
                });
            }

            Console.WriteLine("Procitali smo " + lst.Count);
            
            var entityList = new List<CategoryEntity>();

            foreach (var cat in lst)
            {
                entityList.Add(new CategoryEntity
                {
                    Code = cat.Code,
                    Name = cat.Name,
                    ParentCode = cat.ParentCode
                });
            }

            await repo.add(entityList);

            return await Task.FromResult(new Result<CategoryList>()
            {
                StatusCodeResponse = new OkObjectResult(null),
                StatusCode = (int)HttpStatusCode.OK,
                Response = new CategoryList()
            });;

        }
    }
}
