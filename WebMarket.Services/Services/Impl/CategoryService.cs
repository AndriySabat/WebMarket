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

        public async Task<List<Category>> GetAll()
        {
            var categories = await categoryProvider.GetAll();
            var mainCategories = categories.Where(item => item.SubCategoryId == null).ToList();

            var result = CascadeCategories(mainCategories, categories.Where(item => !mainCategories.Contains(item)));
            return result.ToList();
        }

        public async Task<int> AddCategories(IList<Category> categories)
        {
            return await categoryProvider.Add(categories);
        }

        private IEnumerable<Category> CascadeCategories(IEnumerable<Category> mainCategories, IEnumerable<Category> categories)
        {
            var result = new List<Category>();
            var groupedCategories = categories.GroupBy(item => item.Id);
            
            foreach (var category in mainCategories)
            {
                category.SubCategories = groupedCategories.Where(item => item.Key == category.Id).Select(item => item.ToList()).FirstOrDefault();
                CascadeCategories(category.SubCategories, categories.Where(item => !category.SubCategories.Contains(item)));
            }
            return mainCategories;
        }
    }
}
