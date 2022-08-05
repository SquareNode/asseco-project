using Microsoft.EntityFrameworkCore;
using projekat.Database.Entities;

namespace projekat.Database.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CategoryEntity> builder)
        {
            builder.ToTable("category");
            builder.HasKey(p => p.Code);
            builder.Property(p => p.Code).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.ParentCode).IsRequired();
          
        }
    }
}