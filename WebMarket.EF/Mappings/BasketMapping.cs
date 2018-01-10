using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebMarket.EF.Entities;

namespace WebMarket.EF.Mappings
{
    public class BasketMapping
    {
        public static void Configure(EntityTypeBuilder<BasketEntity> builder)
        {
            builder.ToTable("Basket");

            builder.Property(b => b.UserId).IsRequired().HasColumnName("UserFID");
            builder.Property(b => b.ProductId).IsRequired().HasColumnName("ProductFID");
            builder.Property(b => b.Count).IsRequired().HasColumnName("Count");
            builder.Property(b => b.CreatedAt).IsRequired().ValueGeneratedOnAdd();

            builder.HasKey(b => new { b.ProductId, b.UserId });

            builder.HasOne(b => b.User)
                .WithMany(u => u.ProductsInBasket)
                .HasForeignKey(b => b.UserId);

            builder.HasOne(b => b.Product)
                .WithMany(p => p.Baskets)
                .HasForeignKey(b => b.ProductId);
        }
    }
}
