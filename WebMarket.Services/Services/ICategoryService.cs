using System.Threading.Tasks;
using System.Collections.Generic;
using WebMarket.DTO;

namespace WebMarket.Services
{
    /// <summary>
    /// ICategoryService interface
    /// </summary>
    public interface ICategoryService
    {
        /// <summary>
        /// Get all getegories with his parents and sub categories
        /// </summary>
        /// <returns>List of categories</returns>
        Task<List<Category>> GetAll();

        /// <summary>
        /// Add new categories
        /// </summary>
        /// <param name="categories"></param>
        /// <returns>Number affected rows</returns>
        Task<int> AddCategories(IList<Category> categories);
    }
}
