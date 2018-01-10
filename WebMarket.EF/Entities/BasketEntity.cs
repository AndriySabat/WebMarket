using System;
using WebMarket.EF.Entities;

namespace WebMarket.EF.Entities
{
    public class BasketEntity
    {
        public long UserId { get; set; }

        public long ProductId { get; set; }

        public DateTime CreatedAt { get; set; }

        public int Count { get; set; }

        public virtual UserEntity User { get; set; }

        public virtual ProductEntity Product { get; set; }
    }
}
