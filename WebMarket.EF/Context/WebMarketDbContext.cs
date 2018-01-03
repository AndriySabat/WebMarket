using Microsoft.EntityFrameworkCore;
using WebMarket.EF.Entities;
using WebMarket.EF.Mappings;

namespace WebMarket.EF.Context
{
    public class WebMarketDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<UserEntity> Users { get; set; }

        public DbSet<BasketEntity> Basket { get; set; }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<SubCategoryEntity> SubCategories { get; set; }

        public DbSet<ProductCharacteristicEntity> ProductCharacteristics { get; set; }
    }
}
