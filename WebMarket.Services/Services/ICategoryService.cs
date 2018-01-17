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

        /// <summary>
        /// Add new category
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Number affected rows</returns>
        Task<int> AddCategory(Category category);

        /// <summary>
        /// Update category
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Number affected rows</returns>
        Task<int> UpdateCategory(Category category);

        /// <summary>
        /// Update categories
        /// </summary>
        /// <param name="categories"></param>
        /// <returns>Number affected rows</returns>
        Task<int> UpdateCategories(IEnumerable<Category> categories);

        /// <summary>
        /// Remove category
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Number affected rows</returns>
        Task<int> RemoveCategory(Category category);

        /// <summary>
        /// Remove categories
        /// </summary>
        /// <param name="categories"></param>
        /// <returns>Number affected rows</returns>
        Task<int> RemoveCategories(IEnumerable<Category> categories);
    }
}
