using System.Collections.Generic;

namespace WebMarket.EF.Entities
{
    public class CategoryEntity
    {
        public long CategoryId { get; set; }

        public string Description { get; set; }
        
        public long? SubCategoryId { get; set; }

        public virtual ICollection<CategoryEntity> SubCategories { get; set; }

        public virtual CategoryEntity ParentCategory { get; set; }

        public virtual ICollection<ProductEntity> Products { get; set; }
    }
}
