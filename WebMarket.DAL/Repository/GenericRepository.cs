using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebMarket.DAL.Repository
{
    internal class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// The context
        /// </summary>
        protected readonly DbContext Context;

        /// <summary>
        /// The _DB set
        /// </summary>
        private readonly DbSet<TEntity> dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository{TEntity}" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public GenericRepository(DbContext context)
        {
            this.Context = context;
            this.dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// Queries this instance.
        /// </summary>
        /// <returns>IQueryable&lt;TEntity&gt;.</returns>
        public IQueryable<TEntity> Query()
        {
            return this.dbSet.AsQueryable();
        }

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Add(TEntity entity)
        {
            this.dbSet.Add(entity);
        }

        /// <summary>
        /// Adds the range.
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void AddRange(IEnumerable<TEntity> entities)
        {
            this.dbSet.AddRange(entities);
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Update(TEntity entity)
        {
            this.dbSet.Attach(entity);
            this.Context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Removes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Remove(TEntity entity)
        {
            this.dbSet.Remove(entity);
        }

        /// <summary>
        /// Removes the range.
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            this.dbSet.RemoveRange(entities);
        }
    }
}
