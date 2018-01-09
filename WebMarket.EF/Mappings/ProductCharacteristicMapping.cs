using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebMarket.EF.Mappings
{
    public class ProductCharacteristicMapping
    {
        public static void Configure(EntityTypeBuilder<ProductCharacteristicEntity> builder)
        {
            builder.ToTable("Product_Characteristic");

            builder.Property(c => c.CharacteristicId).UseSqlServerIdentityColumn().HasColumnName("Characteristic_UID");
            builder.Property(c => c.ProductId).IsRequired().HasColumnName("ProductFID");
            builder.Property(c => c.Description).IsRequired().HasColumnName("Description");

            builder.HasKey(c => c.CharacteristicId);
        }
    }
}
