using Microsoft.EntityFrameworkCore;
using WebMarket.EF.Entities;
using WebMarket.EF.Mappings;

namespace WebMarket.EF.Context
{
    public class WebMarketDbContext : DbContext
    {
        public WebMarketDbContext()
        {
        }

        public WebMarketDbContext(DbContextOptions<WebMarketDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>(ProductMapping.Configure);
            modelBuilder.Entity<UserEntity>(UserMapping.Configure);
            modelBuilder.Entity<SubCategoryEntity>(SubCategoryMapping.Configure);
            modelBuilder.Entity<CategoryEntity>(CategoryMapping.Configure);
            modelBuilder.Entity<ProductCharacteristicEntity>(ProductCharacteristicMapping.Configure);
            modelBuilder.Entity<BasketEntity>(BasketMapping.Configure);
        }

        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<UserEntity> Users { get; set; }

        public DbSet<BasketEntity> Basket { get; set; }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<SubCategoryEntity> SubCategories { get; set; }

        public DbSet<ProductCharacteristicEntity> ProductCharacteristics { get; set; }
    }
}
