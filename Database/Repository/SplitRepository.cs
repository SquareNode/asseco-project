using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
using Microsoft.EntityFrameworkCore;
using projekat.Database.Entities;

namespace projekat.Database.Repository
{
    public class SplitRepository : ISplitRepository
    {
        private readonly TransactionDBContext _dbcontext;

        public SplitRepository(TransactionDBContext context)
        {
            _dbcontext = context;
        }

        public async Task<SplitEntity> add(SplitEntity entity)
        {

            try
            {
                var m = _dbcontext;

                _dbcontext.Splits.Add(entity);

                var z = _dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {

            }

            return await Task.FromResult(entity);
        }

        //public class Foo
        //{
        //    public TransactionEntity t { get; set; }
        //    public SplitEntity s { get; set; }
        //}


        public async Task<SpendingsByCategory> find(string catCode, DateTime startdate, DateTime enddate, string direction)
        {
            //var res = _dbcontext.Splits.Where(e => e.CatCode == catCode && e.Transaction.date <= enddate && e.Transaction.date >= startdate
            //&& e.Transaction.direction == direction[0]).ToList();

            //var resObj = new SpendingsByCategory();

            //foreach(var r in res)
            //{
            //    resObj.Groups.Add(new SpendingByCategory
            //    {
            //        Catcode = r.CatCode,
            //        Amount = r.Amount,
            //        Count = 0
            //    });
            //}

            //return await Task.FromResult(resObj);
            return null;



            //var res =  _dbcontext.Splits.Where(p => p.CatCode == catCode).Join(_dbcontext.Transactions,
            //    fst => fst.TransactionId, snd => snd.id, (fst, snd) => new
            //    {
            //        SplitEntity = fst,
            //        TransactionEntity = snd
            //    }).Where(p => p.TransactionEntity.date >= startdate &&
            //    p.TransactionEntity.date <= enddate &&
            //    p.TransactionEntity.direction == direction[0]).ToList();

            //var resLst = new List<Foo>();
            //foreach (var r in res)
            //{
            //    resLst.Add(new Foo
            //    {
            //        s = r.SplitEntity,
            //        t = r.TransactionEntity
            //    });
            //}

            //return await Task.FromResult(resLst);
        }

        public async Task<List<SingleCategorySplit>> split(string id, List<SingleCategorySplit> splitList )
        {

            var tx = _dbcontext.Transactions.Where(p => p.id == id).First();

           
            var alreadySplit = _dbcontext.Splits.Where(p => p.TransactionId == id).ToList();
            if (alreadySplit.Count > 0) { 
                foreach(var entity in alreadySplit)
                    _dbcontext.Splits.Remove(entity);
                _dbcontext.SaveChanges();
            }


            //var txAmt = tx.amount;
            //var splitAmt = splitList.Sum(p => p.Amount);

            //if (splitAmt > txAmt)
            //{
            //    return null;
            //}

            foreach (var split in splitList)
            {
                var cat = _dbcontext.Categories.Where(p => p.Code == split.Catcode).First();
                var z = await add(new SplitEntity
                {
                    TransactionId = id,
                    CatCode = split.Catcode,
                    Amount = (double)split.Amount,
                    Transaction = tx,
                    Category = cat
                });
            }
            await _dbcontext.SaveChangesAsync();

            return await Task.FromResult(splitList);

        }
    }
}
