using System.Collections.Generic;

namespace WebMarket.EF.Entities
{
    public class CategoryEntity
    {
        public long CategortId { get; set; }

        public string Description { get; set; }

        public virtual ICollection<SubCategoryEntity> SubCategories { get; set; }
    }
}
