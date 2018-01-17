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
    }
}
