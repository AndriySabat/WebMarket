using System;
using System.Collections.Generic;
using System.Text;

namespace WebMarket.EF.Entities
{
    public class ProductEntity
    {
        public int ProductId { get; set; }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public double Discount { get; set; }

        public string ManufacturedCountry { get; set; }
    }
}
