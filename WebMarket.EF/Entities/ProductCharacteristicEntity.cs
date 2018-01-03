using System;
using System.Collections.Generic;
using System.Text;

namespace WebMarket.EF.Entities
{
    public class ProductCharacteristicEntity
    {
        public int CharacteristicId { get; set; }

        public int ProductId { get; set; }

        public string Description { get; set; }
    }
}
