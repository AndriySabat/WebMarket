using System;
using System.Threading.Tasks;
using WebMarket.DAL.Repository;
using WebMarket.EF.Entities;

namespace WebMarket.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<ProductEntity> ProductResitory { get; }

        IGenericRepository<UserEntity> UserRepository { get; }

        IGenericRepository<BasketEntity> BasketRepository { get; }

        IGenericRepository<CategoryEntity> CategoryRepository { get; }

        IGenericRepository<SubCategoryEntity> SubCategoryRepository { get; }

        IGenericRepository<ProductCharacteristicEntity> ProductCharacteristicRepository { get; }

        /// <summary>
        /// Saves the changes asynchronous.
        /// </summary>
        /// <returns>Task&lt;System.Int32&gt;.</returns>
        Task<int> SaveChangesAsync();

        /// <summary>
        /// Saves the changes.
        /// </summary>
        /// <returns>System.Int32.</returns>
        int SaveChanges();
    }
}
