using System.Collections.Generic;
using System.Threading.Tasks;
using WebMarket.DTO;


namespace WebMarket.DAL.Providers
{
    /// <summary>
    /// ICategory Interface 
    /// </summary>
    public interface ICategoryProvider
    {
        /// <summary>
        /// Get all categories
        /// </summary>
        /// <returns>List of Categories</returns>
        Task<List<Category>> GetAll();

        /// <summary>
        /// Add new Categories
        /// </summary>
        /// <param name="category"></param>
        /// <returns>number affected rows</returns>
        Task<int> Add(IList<Category> category);
    }
}
