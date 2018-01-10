using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebMarket.EF.Entities;

namespace WebMarket.EF.Mappings
{
    public class UserMapping
    {
        public static void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users");

            builder.Property(u => u.UserId).UseSqlServerIdentityColumn().HasColumnName("User_UID");
            builder.Property(u => u.FirstName).IsRequired().HasColumnName("FirstName").HasMaxLength(50);
            builder.Property(u => u.LastName).IsRequired().HasColumnName("LastName").HasMaxLength(50);
            builder.Property(u => u.MiddleName).IsRequired(false).HasColumnName("MiddleName").HasMaxLength(50);
            builder.Property(u => u.Email).IsRequired().HasColumnName("Email");
            builder.Property(u => u.PhoneNumber).IsRequired(false).HasColumnName("PhoneNumber");

            builder.HasKey(u => u.UserId);
        }
    }
}
