using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using WebMarket.DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using WebMarket.DTO;
using WebMarket.EF.Entities;

namespace WebMarket.DAL.Providers.Impl
{
    /// <summary>
    /// Category Provider class
    /// </summary>
    public class CategoryProvider : ICategoryProvider
    {
        /// <summary>
        /// The Unit Of Work Factory
        /// </summary>
        private IUnitOfWorkFactory unitOfWorkFactory;

        /// <summary>
        /// Initializes a new instance of the CategorProvider class
        /// </summary>
        /// <param name="unitOfWorkFactory"></param>
        public CategoryProvider(IUnitOfWorkFactory unitOfWorkFactory)
        {
            this.unitOfWorkFactory = unitOfWorkFactory;
        }

        /// <summary>
        /// Get list of categories 
        /// </summary>
        /// <returns>List of Categories</returns>
        public async Task<List<Category>> GetAll()
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                return await uow.CategoryRepository.Query()
                    .Select(item => new Category
                    {
                        Id = item.CategoryId,
                        SubCategoryId = item.SubCategoryId,
                        Description = item.Description,
                    }).ToListAsync();
            }
        }
    }
}
