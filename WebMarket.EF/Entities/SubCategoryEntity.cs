using System;
using System.Collections.Generic;
using System.Text;

namespace WebMarket.EF.Entities
{
    public class SubCategoryEntity
    {
        public int SubCategoryId { get; set; }

        public int CategoryId { get; set; }

        public string Description { get; set; }
    }
}
