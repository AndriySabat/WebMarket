using System.Collections.Generic;
using System.Linq;

namespace WebMarket.DAL.Repository
{
    public interface IGenericRepository<TEntity> where TEntity: class
    {
        IQueryable<TEntity> Query();

        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
