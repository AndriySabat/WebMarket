using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using WebMarket.DTO;
using WebMarket.DAL.Providers;
using WebMarket.DAL.UnitOfWork;
using WebMarket.EF.Entities;

namespace WebMarket.Services.Impl
{
    /// <summary>
    /// CategoryService class
    /// </summary>
    public class CategoryService : ICategoryService
    {
        /// <summary>
        /// The category provider
        /// </summary>
        private ICategoryProvider categoryProvider;

        /// <summary>
        /// The Unit Of Work
        /// </summary>
        private IUnitOfWorkFactory unitOfWorkFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryService" /> class.
        /// </summary>
        /// <param name="categoryProvider">The category provider</param>
        public CategoryService(ICategoryProvider categoryProvider, IUnitOfWorkFactory unitOfWorkFactory)
        {
            this.categoryProvider = categoryProvider;
            this.unitOfWorkFactory = unitOfWorkFactory;
        }

        /// <summary>
        /// Get All Categories
        /// </summary>
        /// <returns>List of categories</returns>
        public async Task<List<Category>> GetAll()
        {
            return await categoryProvider.GetAll();
        }

        /// <summary>
        /// Save list of categories
        /// </summary>
        /// <param name="categories"></param>
        /// <returns>Number affected rows</returns>
        public async Task<int> AddCategories(IList<Category> categories)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                var categoryEntities = categories.Select(item => new CategoryEntity
                {
                    Description = item.Description,
                    SubCategoryId = item.SubCategoryId
                });
                uow.CategoryRepository.AddRange(categoryEntities);
                return await uow.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Save category
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Number affected rows</returns>
        public async Task<int> AddCategory(Category category)
        {
            return await AddCategories(new List<Category>() { category });
        }

        /// <summary>
        /// Update categories
        /// </summary>
        /// <param name="categories"></param>
        /// <returns>Number affected rows</returns>
        public async Task<int> UpdateCategories(IEnumerable<Category> categories)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                foreach (var category in categories)
                {
                    var categoryToUpdate = new CategoryEntity
                    {
                        CategoryId = category.Id,
                        Description = category.Description,
                        SubCategoryId = category.SubCategoryId
                    };
                    uow.CategoryRepository.Update(categoryToUpdate);
                }

                return await uow.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Update category
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Number affected rows</returns>
        public async Task<int> UpdateCategory(Category category)
        {
            return await UpdateCategories(new List<Category>() { category });
        }

        /// <summary>
        /// Remove categories
        /// </summary>
        /// <param name="categories"></param>
        /// <returns>Number affected rows</returns>
        public async Task<int> RemoveCategories(IEnumerable<Category> categories)
        {
            using (var uow = unitOfWorkFactory.CreateUnitOfWork())
            {
                var categoriesToRemove = categories.Select(item => new CategoryEntity
                {
                    CategoryId = item.Id
                });
                uow.CategoryRepository.RemoveRange(categoriesToRemove);

                return await uow.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Remove Category
        /// </summary>
        /// <param name="category"></param>
        /// <returns>Number affected rows</returns>
        public async Task<int> RemoveCategory(Category category)
        {
            return await RemoveCategories(new List<Category>() { category });
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
