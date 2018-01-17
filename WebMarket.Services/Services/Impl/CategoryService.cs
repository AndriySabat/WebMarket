using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using WebMarket.DTO;
using WebMarket.Services;
using WebMarket.DAL.Providers;

namespace WebMarket.Services.Impl
{
    /// <summary>
    /// CategorService class
    /// </summary>
    public class CategoryService : ICategoryService
    {
        /// <summary>
        /// The category provider
        /// </summary>
        private ICategoryProvider categoryProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryService" /> class.
        /// </summary>
        /// <param name="categoryProvider">The category provider</param>
        public CategoryService(ICategoryProvider categoryProvider)
        {
            this.categoryProvider = categoryProvider;
        }

        /// <summary>
        /// Get All Categories
        /// </summary>
        /// <returns></returns>
        public async Task<List<Category>> GetAll()
        {
            return await categoryProvider.GetAll();
        }


        public async Task<int> AddCategories(IList<Category> categories)
        {
            return await categoryProvider.Add(categories);
        }

        #region may be useful
        //public async Task<List<Category>> GetAll()
        //{
        //    var categories = await categoryProvider.GetAll();
        //    var mainCategories = categories.Where(item => item.SubCategoryId == null).ToList();

        //    var result = CascadeCategories(mainCategories, categories.Where(item => !mainCategories.Contains(item)).ToList());
        //    return result.ToList();
        //}
        //private IEnumerable<Category> CascadeCategories(IEnumerable<Category> mainCategories, IEnumerable<Category> categories)
        //{
        //    if(categories == null || !categories.Any())
        //    {
        //        return null;
        //    }
        //    var groupedCategories = categories.GroupBy(item => item.SubCategoryId);
            
        //    foreach (var category in mainCategories)
        //    {
        //        category.SubCategories = groupedCategories.Where(item => item.Key == category.Id).Select(item => item.ToList()).FirstOrDefault();
        //        CascadeCategories(category.SubCategories, categories.Where(item => !category.SubCategories.Contains(item)).ToList());
        //    }
        //    return mainCategories;
        //}
        #endregion
    }
}
