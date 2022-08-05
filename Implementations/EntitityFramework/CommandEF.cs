using Asseco.Contracts.Errors;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.HttpParams;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.ServiceContracts;
using Asseco.REST.Contracts.Generics;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using projekat.Database.Entities;
using projekat.Database.Repository;
using System.Net;

namespace projekat.Implementations.EntitityFramework
{
    public class CommandEF : IPersonalFinanceManagementAPITransactionsCommandService
    {

        private readonly ITransactionsRepository trRepo;
        private readonly ICategoryRepository catRepo;
        private readonly ISplitRepository splitRepo;
        private readonly IMapper mapper;

        public CommandEF(ITransactionsRepository trRepo, ICategoryRepository catRepo,ISplitRepository splitRepo
            , IMapper mapper)
        {
            this.trRepo = trRepo;
            this.catRepo = catRepo;
            this.splitRepo = splitRepo;
            this.mapper = mapper;
        }
        public Task<Result<TransactionPagedList>> TransactionsAutoCategorizeAsync(TransactionsAutoCategorizeHttpParams transactionsAutoCategorizeHttpParams)
        {
            throw new NotImplementedException();
        }

        public async Task<Result<TransactionPagedList>> TransactionsCategorizeAsync(TransactionsCategorizeHttpParams transactionsCategorizeHttpParams, TransactionCategorizeCommand transactionCategorizeCommand)
        {

            var tx = trRepo.getById(transactionsCategorizeHttpParams.Id);
            if(tx == null)
                return await Task.FromResult(new Result<TransactionPagedList>()
                {
                    StatusCodeResponse = new OkObjectResult(new ValidationError
                    {
                        Error = "tx not in db",
                        Message = "transaction with id " + transactionsCategorizeHttpParams.Id + " not in database",
                        Tag = "tx not in db"
                    }),
                    StatusCode = (int)HttpStatusCode.BadRequest,
                });
            var category = catRepo.getByCode(transactionCategorizeCommand.Catcode);
            if(category == null)
                return await Task.FromResult(new Result<TransactionPagedList>()
                {
                    StatusCodeResponse = new OkObjectResult(new ValidationError
                    {
                        Error = "cat not in db",
                        Message = "category with code " + transactionCategorizeCommand.Catcode + " not in database",
                        Tag = "cat not in db"
                    }),
                    StatusCode = (int)HttpStatusCode.BadRequest,
                });

            await trRepo.categorizeTx(transactionsCategorizeHttpParams.Id, transactionCategorizeCommand.Catcode);


            return await Task.FromResult(new Result<TransactionPagedList>()
            {
                StatusCodeResponse = new OkObjectResult(null),
                StatusCode = (int)HttpStatusCode.OK,
                Response = new TransactionPagedList()
            }); ;
        }

        public async Task<Result<TransactionPagedList>> TransactionsImportAsync(IFormFile file)
        {

            var stream = file.OpenReadStream();
            StreamReader reader = new StreamReader(stream);

            var transactionList = new List<Transaction>();

            string line;
            string[] row;
            reader.ReadLine();

            double amt = default;
            MccCodeEnum mccEnum = default;

            var errArr = new List<ValidationError>();
            var i = 0;

            while ((line = reader.ReadLine()) != null)
            {
                row = line.Split(',');

                if (row.Length != 9)
                {
                    errArr.Add(new ValidationError
                    {
                        Tag = "line : " + i.ToString(),
                        Error = "invalid num of args",
                        Message = "Invalid number of fields"
                    });
                    continue;
                   
                }

                if (row[3].Length > 1 || (row[3][0] != 'c' && row[3][0] != 'd'))
                {
                    errArr.Add(new ValidationError
                    {
                        Tag = "line : " + i.ToString(),
                        Error = "direction",
                        Message = "Direction must be d or c"
                    });
                    continue;

                    
                }
                amt = default;
                double.TryParse(row[4], out amt);
                if (amt == default)
                {
                    errArr.Add(new ValidationError
                    {
                        Tag = "line : " + i.ToString(),
                        Error = "amt",
                        Message = "Invalid amount field"
                    }); 
                }

                mccEnum = default;

                Enum.TryParse<MccCodeEnum>(row[7], out mccEnum);

                transactionList.Add(new Transaction
                {
                    Id = row[0],
                    BeneficiaryName = row[1],
                    Date = row[2],
                    Direction = row[3],
                    Amount = amt, 
                    Description = row[5],
                    Currency = row[6],
                    Mcc = mccEnum,
                    Kind = row[8]
                });
                i++;

            }

            if (errArr.Count() > 0)
                return await Task.FromResult(new Result<TransactionPagedList>()
                {
                    StatusCodeResponse = new BadRequestObjectResult(errArr),
                    StatusCode = (int)HttpStatusCode.BadRequest,

                });

            var transactionEntityList = new List<TransactionEntity>();

            foreach (var tr in transactionList)
            {
                if (((int)tr.Mcc) != 0)
                {
                    transactionEntityList.Add(new TransactionEntity
                    {
                        id = tr.Id,
                        beneficiaryName = tr.BeneficiaryName,
                        date = DateTime.Parse(tr.Date).ToUniversalTime(),
                        direction = tr.Direction[0],
                        amount = (double)tr.Amount,
                        description = tr.Description,
                        currency = tr.Currency,
                        mcc = ((int)tr.Mcc),
                        kind = tr.Kind
                    });

                }
                else
                {
                    transactionEntityList.Add(new TransactionEntity
                    {
                        id = tr.Id,
                        beneficiaryName = tr.BeneficiaryName,
                        date = DateTime.Parse(tr.Date).ToUniversalTime(),
                        direction = tr.Direction[0],
                        amount = (double)tr.Amount,
                        description = tr.Description,
                        currency = tr.Currency,
                        kind = tr.Kind
                    });
                }
            }

            var dummy = await trRepo.addRange(transactionEntityList);


            return await Task.FromResult(new Result<TransactionPagedList>()
            {
                StatusCodeResponse = new OkObjectResult(null),
                StatusCode = (int)HttpStatusCode.OK,
                Response = new TransactionPagedList()
            });

        }

        public Task<Result<TransactionPagedList>> TransactionsSplitAsync(TransactionsSplitHttpParams transactionsSplitHttpParams, SplitTransactionCommand splitTransactionCommand)
        {

            //check TX
            var txCheck = trRepo.getById(transactionsSplitHttpParams.Id);
            if (txCheck == null)
                return Task.FromResult(new Result<TransactionPagedList>()
                {
                    StatusCodeResponse = new BadRequestObjectResult(new ValidationError
                    {
                        Error = "no tx",
                        Message = "Transacion with id" + transactionsSplitHttpParams.Id.ToString() + " not found",
                        Tag = "no tx"
                    }),
                    StatusCode = (int)HttpStatusCode.BadRequest
                });

            //check cats
            foreach (var split in splitTransactionCommand.Splits)
            {   
                if (split.Amount <= 0)
                    return Task.FromResult(new Result<TransactionPagedList>()
                    {
                        StatusCodeResponse = new BadRequestObjectResult(new ValidationError
                        {
                            Error = "amt < 0",
                            Message = "Split amount (" + split.Amount.ToString() + ") less than 0",
                            Tag = "amt less than 0"
                        }),
                        StatusCode = (int)HttpStatusCode.BadRequest
                    });
                if (catRepo.getByCode(split.Catcode) == null)
                    return Task.FromResult(new Result<TransactionPagedList>()
                    {
                        StatusCodeResponse = new BadRequestObjectResult(new ValidationError
                        {
                            Error = "no cat",
                            Message = "Category " + split.Catcode + " not found",
                            Tag = "no cat"
                        }),
                        StatusCode = (int)HttpStatusCode.BadRequest
                    });
            }

            //check amount
            var splitAmt = splitTransactionCommand.Splits.Sum(p => p.Amount);
            if (txCheck.Result.amount < splitAmt)
                return Task.FromResult(new Result<TransactionPagedList>()
                {
                    StatusCodeResponse = new BadRequestObjectResult(new ValidationError
                    {
                        Error = "amt",
                        Message = "Split amouns (" + splitAmt.ToString() + ") is larger than transaction amount ("
                        + txCheck.Result.amount.ToString() + ").",
                        Tag = "split amt > tx amt"
                    }),
                    StatusCode = (int)HttpStatusCode.BadRequest
                });


            var res = splitRepo.split(transactionsSplitHttpParams.Id, splitTransactionCommand.Splits);

            return Task.FromResult(new Result<TransactionPagedList>()
            {
                StatusCodeResponse = new OkResult(),
                StatusCode = (int)HttpStatusCode.OK,
                Response = new TransactionPagedList()
            });
        }
    }
}
