using System.Threading.Tasks;
using WebMarket.EF.Entities;
using WebMarket.DAL.Repository;
using WebMarket.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace WebMarket.DAL.UnitOfWork
{
    public class WebMarketUnitOfWork : IUnitOfWork
    {
        protected readonly WebMarketDbContext context = new WebMarketDbContext(new DbContextOptions<WebMarketDbContext>());

        private IGenericRepository<ProductEntity> productResitory;

        private IGenericRepository<UserEntity> userRepository;

        private IGenericRepository<BasketEntity> basketRepository;

        private IGenericRepository<CategoryEntity> categoryRepository;

        private IGenericRepository<ProductCharacteristicEntity> productCharacteristicRepository;

        public WebMarketUnitOfWork()
        {
        }

        public IGenericRepository<ProductEntity> ProductResitory => this.productResitory ?? (this.productResitory = new GenericRepository<ProductEntity>(context));

        public IGenericRepository<UserEntity> UserRepository => this.userRepository ?? (this.userRepository = new GenericRepository<UserEntity>(context));

        public IGenericRepository<BasketEntity> BasketRepository => this.basketRepository ?? (this.basketRepository = new GenericRepository<BasketEntity>(context));

        public IGenericRepository<CategoryEntity> CategoryRepository => this.categoryRepository ?? (this.categoryRepository = new GenericRepository<CategoryEntity>(context));

        public IGenericRepository<ProductCharacteristicEntity> ProductCharacteristicRepository => this.productCharacteristicRepository ?? (this.productCharacteristicRepository = new GenericRepository<ProductCharacteristicEntity>(context));

        public void Dispose()
        {
            this.context.Dispose();
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return this.context.SaveChangesAsync();
        }
    }
}
