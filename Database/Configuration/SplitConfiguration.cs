using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using projekat.Database.Entities;

namespace projekat.Database.Configuration
{
    
    public class SplitConfiguration : IEntityTypeConfiguration<SplitEntity> 
    {

        public void Configure(EntityTypeBuilder<SplitEntity> builder)
        {
            builder.ToTable("split");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().IsRequired();

            builder.Property(p => p.CatCode).IsRequired();

            builder.Property(p => p.TransactionId).IsRequired();

            builder.HasOne(p => p.Transaction).WithMany(p => p.split).HasForeignKey(p => p.TransactionId);
            builder.HasOne(p => p.Category).WithMany().HasForeignKey(p => p.CatCode);

        }
    }
}
