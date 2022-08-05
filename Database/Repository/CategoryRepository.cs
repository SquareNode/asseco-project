using projekat.Database.Entities;

namespace projekat.Database.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TransactionDBContext _dbcontext;

        public CategoryRepository(TransactionDBContext context)
        {
            _dbcontext = context;
        }
        public async Task<List<CategoryEntity>> add(List<CategoryEntity> entityList)
        {
            var d = _dbcontext;

            //Ocisti entityList from duplicates

            var entityListDuplicateCodes = entityList.GroupBy(p => p.Code).Where(p => p.Count() > 1).Select(p => p.Key);
            var entityListDuplicates = entityList.Where(p => entityListDuplicateCodes.Contains(p.Code));

            var jedinicni = entityList.GroupBy(p => p.Code).Where(p => p.Count() == 1).SelectMany(p => p).ToList();
            foreach(var code in entityListDuplicateCodes)
            {
                jedinicni.Add(entityList.LastOrDefault(s => s.Code == code));
            }

            //foreach(var dup in duplicates)
            //    entityList.Add(dup);

            var allInsertCodes = entityList.Select(s => s.Code).Distinct();

            var duplicateEntities = _dbcontext.Categories.Where(e => allInsertCodes.Contains(e.Code));


            //var allParentCodes = entityList.Select(p => p.ParentCode).Distinct();

            //var parentsToDelete = _dbcontext.Categories.Where(e => allParentCodes.Contains(e.ParentCode));

            //_dbcontext.RemoveRange(parentsToDelete);

            var parents = entityList.Where(p => string.IsNullOrEmpty(p.ParentCode)).Select(p => p.Code).ToList();

            var dataInDb = _dbcontext.Categories.Where(p => string.IsNullOrEmpty(p.ParentCode)).Select(p => p.Code).ToList();
            parents.AddRange(dataInDb);
            parents = parents.Distinct().ToList();
            
            var toWrite = jedinicni.Where(p => string.IsNullOrEmpty(p.ParentCode) || parents.Contains(p.ParentCode)).ToList();


            _dbcontext.RemoveRange(duplicateEntities);
            
            await _dbcontext.AddRangeAsync(toWrite);
            //await _dbcontext.AddRangeAsync(duplicates);

            var z = await _dbcontext.SaveChangesAsync();
   

            //var duplikati = entityList.GroupBy(p => p.Code).Where(p => p.Count() > 1).Select(p => p.Key).Distinct();
            //.TakeLast(1).SelectMany(p => p).ToList();


            //entityList = entityKList.GroupBy(p => p.Code).Where(p => p.Count() == 1)
            //    .SelectMany(p => p).ToList();



            //foreach (var dup in duplikati)
            //    entityList.Add(dup);

            //t = t.GetRange(0, 5);

            //_dbcontext.Categories.UpdateRange(entityList);

            //_dbcontext.Categories.AddRange(entityList);
            //_dbcontext.Categories.AddRange(duplikati);

            //var z = _dbcontext.SaveChanges();

            return await Task.FromResult(entityList);
        }

        //Task<Iqueriable<...
        public async Task<List<CategoryEntity>> get()
        {
            //return await _dbcontext.Transactions;
            //return null;
            //var v = _dbcontext.Transactions.Where(e => e.direction == 'a');
            //v = v.Where(e => e.id == "1");
            //return v.ToList();

            var res = _dbcontext.Categories.ToList();
            return res;
        }

        public Task<CategoryEntity> getByCode(string code)
        {
            var res = _dbcontext.Categories.Where(p => p.Code == code).ToList();
            if (res.Count() == 0)
                return null;
            return Task.FromResult(res.First());
        }
    }
}
