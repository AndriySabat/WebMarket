using System.Collections.Generic;

namespace WebMarket.EF.Entities
{
    public class ProductEntity
    {
        public ProductEntity()
        {
            Characteristics = new List<ProductCharacteristicEntity>();
            Baskets = new List<BasketEntity>();
        }
        public long ProductId { get; set; }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public double? Discount { get; set; }

        public string ManufacturedCountry { get; set; }

        public long CategoryId { get; set; }

        public virtual ICollection<ProductCharacteristicEntity> Characteristics { get; set; }

        public virtual ICollection<BasketEntity> Baskets { get; set; }

        public virtual CategoryEntity Category { get; set; }
    }
}
