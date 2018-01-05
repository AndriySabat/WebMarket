using System.Collections.Generic;
using WebMarket.EF.Entities;

namespace WebMarket.EF.Entities
{
    public class CategoryEntity
    {
        public int CategortId { get; set; }

        public string Description { get; set; }

        public virtual ICollection<SubCategoryEntity> SubCategories { get; set; }
    }
}
