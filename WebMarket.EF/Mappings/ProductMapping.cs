using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebMarket.EF.Entities;

namespace WebMarket.EF.Mappings
{
    public class ProductMapping
    {
        public static void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.ToTable("Products");
            
            builder.Property(p => p.ProductId).UseSqlServerIdentityColumn().HasColumnName("Product_UID");
            builder.Property(p => p.ProductCode).HasColumnName("Code").IsRequired().HasMaxLength(30);
            builder.Property(p => p.ProductName).HasColumnName("Name").IsRequired();
            builder.Property(p => p.Price).HasColumnName("Price").IsRequired().HasColumnType("money").HasDefaultValue(0);
            builder.Property(p => p.Discount).HasColumnName("Discount").IsRequired(false);
            builder.Property(p => p.Description).HasColumnName("Description").IsRequired(false);

            builder.HasKey(p => p.ProductId);

            //TODO: need check for composite primary key
            builder.HasMany(p => p.Baskets)
                .WithOne(b => b.Product)
                .HasForeignKey(p => p.ProductId);

            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
