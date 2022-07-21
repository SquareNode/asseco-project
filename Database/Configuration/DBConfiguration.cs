using Microsoft.EntityFrameworkCore;
using projekat.Database.Entities;

namespace projekat.Database.Configuration {
    public class DBConfiguration : IEntityTypeConfiguration<TransactionEntity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TransactionEntity> builder)
        {
            builder.ToTable("transaction");
            builder.HasKey(p => p.id);
            builder.Property(p => p.id).IsRequired();
            builder.Property(p => p.beneficiaryName).IsRequired();
            builder.Property(p => p.date).IsRequired();
            builder.Property(p => p.amount).IsRequired();
            builder.Property(p => p.direction).IsRequired();
            builder.Property(p => p.description).HasMaxLength(100).IsRequired();
            builder.Property(p => p.currency).IsRequired();
            builder.Property(p => p.mcc).IsRequired();
            builder.Property(p => p.kind).IsRequired();

        }
    }
}