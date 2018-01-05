using System.Collections.Generic;

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

        public virtual ICollection<ProductCharacteristicEntity> Characteristics { get; set; }
    }
}
