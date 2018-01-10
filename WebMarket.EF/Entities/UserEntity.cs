using System.Collections.Generic;

namespace WebMarket.EF.Entities
{
    public class UserEntity
    {
        public UserEntity()
        {
            ProductsInBasket = new List<BasketEntity>();
        }

        public long UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public virtual ICollection<BasketEntity> ProductsInBasket { get; set; }
    }
}
