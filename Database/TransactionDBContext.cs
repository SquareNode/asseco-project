using System.Reflection;
using Microsoft.EntityFrameworkCore;
using projekat.Database.Entities;

namespace projekat.Database {
    public class TransactionDBContext : DbContext {
        public TransactionDBContext(DbContextOptions<TransactionDBContext> option) : base (option) {
        }
        public TransactionDBContext (){ 

        }
        public DbSet<TransactionEntity> Transactions {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehaviour", true);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}