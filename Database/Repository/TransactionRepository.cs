using Asseco.Rest.PersonalFinanceManagementAPI.Contracts.V1.DataContracts.Models;
using Microsoft.EntityFrameworkCore;
using projekat.Database.Entities;
using System.Linq;

namespace projekat.Database.Repository
{
    public class TransactionRepository : ITransactionsRepository
    {
        private readonly TransactionDBContext _dbcontext;

        public TransactionRepository(TransactionDBContext context)
        {
            _dbcontext = context;
        }

        public async Task<List<TransactionEntity>> addRange(List<TransactionEntity> t)
        {
            try
            {
                var m = _dbcontext;
                _dbcontext.Transactions.AddRange(t);

                var z = _dbcontext.SaveChanges();
            }catch (Exception e)
            {

            }
            return t;
        }
        public async Task<TransactionEntity> add(TransactionEntity t)
        {

            try
            {
                var m = _dbcontext;

                _dbcontext.Transactions.Add(t);

                var z = _dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {

            }

            return t;
        }

        //Task<Iqueriable<...
        public IQueryable<TransactionEntity> get()
        {
            //return await _dbcontext.Transactions;
            //return null;
            //var v = _dbcontext.Transactions.Where(e => e.direction == 'a');
            //v = v.Where(e => e.id == "1");
            //return v.ToList();

            var res = _dbcontext.Transactions.Include(e => e.split);
            return res;
        }

        public async Task<IQueryable<TransactionEntity>> getIQ()
        {
            //return await _dbcontext.Transactions;
            //return null;
            //var v = _dbcontext.Transactions.Where(e => e.direction == 'a');
            //v = v.Where(e => e.id == "1");
            //return v.ToList();

            var res = _dbcontext.Transactions;
            return res;
        }

        public Task<TransactionEntity> getById(string id)
        {
            var res = _dbcontext.Transactions.ToList().Where(p => p.id == id).ToList();
            if (res.Count() == 0)
                return null;
            return Task.FromResult(res.First());

        }

        public async Task<TransactionEntity> categorizeTx(string id, string catCode)
        {
            var tx = getById(id).Result;

            tx.catCode = catCode;

            _dbcontext.Transactions.Update(tx);

            var res = await _dbcontext.SaveChangesAsync();

            return tx;

        }

        //public async Task<SpendingsByCategory> findAnalytics(string catCode, DateTime startdate, DateTime enddate, string direction)
        //{
        //    var res = _dbcontext.Transactions.Where(e => e.catCode == catCode && e.date <= enddate.ToUniversalTime()
        //    && e.date >= startdate.ToUniversalTime()
        //    && e.direction == direction[0]).ToList();

        //    var resObj = new SpendingsByCategory();

        //    resObj.Groups = new SpendingInCategory();
        //    resObj.Groups.Amount = 0;
        //    resObj.Groups.Count = 0;

        //    foreach (var r in res)
        //    {
        //        resObj.Groups.Catcode = r.catCode;
        //        resObj.Groups.Amount += r.amount;
        //        resObj.Groups.Count++;
        //    }

        //    return await Task.FromResult(resObj);
        //}
    }
}