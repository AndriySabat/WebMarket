using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebMarket.EF.Entities;

namespace WebMarket.EF.Mappings
{
    public class SubCategoryMapping
    {
        public static void Configure(EntityTypeBuilder<SubCategoryEntity> builder)
        {
            builder.ToTable("Sub_Category");

            builder.Property(s => s.SubCategoryId).UseSqlServerIdentityColumn().HasColumnName("SubCategory_UID");
            builder.Property(s => s.CategoryId).IsRequired().HasColumnName("CategoryFID");
            builder.Property(s => s.Description).IsRequired().HasColumnName("Description");

            builder.HasKey(s => s.SubCategoryId);

            builder.HasOne(s => s.Category)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
