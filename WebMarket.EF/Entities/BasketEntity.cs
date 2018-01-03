using System;
using System.Collections.Generic;
using System.Text;

namespace WebMarket.EF.Entities
{
    public class BasketEntity
    {
        public int UserId { get; set; }

        public int ProductId { get; set; }

        public DateTime CreatedAt { get; set; }

        public int Count { get; set; }
    }
}
