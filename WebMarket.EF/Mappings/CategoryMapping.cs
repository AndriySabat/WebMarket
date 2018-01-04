using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebMarket.EF.Entities;

namespace WebMarket.EF.Mappings
{
    public class CategoryMapping
    {
        public CategoryMapping(EntityTypeBuilder<CategoryEntity> builder)
        {
            builder.ToTable("Categories");

            builder.Property(c => c.CategortId).UseSqlServerIdentityColumn().HasColumnName("Category_UID");
            builder.Property(c => c.Description).HasColumnName("Description");

            builder.HasKey(c => c.CategortId);
        }
    }
}
