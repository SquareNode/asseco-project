using System.Reflection;
using Microsoft.EntityFrameworkCore;
using projekat.Database.Entities;

namespace projekat.Database {
    public class TransactionDBContext : DbContext {

        public DbSet<TransactionEntity> Transactions { get; set; }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<SplitEntity> Splits { get; set; }
        public TransactionDBContext(DbContextOptions<TransactionDBContext> option) : base (option) {
        }
        public TransactionDBContext (){ 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehaviour", true);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);

        }
    }
}