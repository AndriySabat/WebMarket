using System.Collections.Generic;

namespace WebMarket.DTO
{
    /// <summary>
    /// Category class
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets category Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Sub Category Id
        /// </summary>
        public long? SubCategoryId { get; set; }

        /// <summary>
        /// Gets or sets Sub Categories
        /// </summary>
        public IEnumerable<Category> SubCategories { get; set; }

        /// <summary>
        /// Gets or set Parent Category
        /// </summary>
        public Category ParentCategory { get; set; }
    }
}
