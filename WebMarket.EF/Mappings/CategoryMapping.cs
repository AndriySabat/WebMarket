using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebMarket.EF.Entities;

namespace WebMarket.EF.Mappings
{
    public class CategoryMapping
    {
        public static void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            builder.ToTable("Categories");

            builder.Property(c => c.CategoryId).UseSqlServerIdentityColumn().HasColumnName("Category_UID");
            builder.Property(c => c.SubCategoryId).IsRequired(false).HasColumnName("CategoryFID");
            builder.Property(c => c.Description).HasColumnName("Description");

            builder.HasKey(c => c.CategoryId);

            builder.HasOne(s => s.ParentCategory)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(s => s.SubCategoryId);
        }
    }
}
