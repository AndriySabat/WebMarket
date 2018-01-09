namespace WebMarket.EF.Entities
{
    public class ProductCharacteristicEntity
    {
        public int CharacteristicId { get; set; }

        public int ProductId { get; set; }

        public string Description { get; set; }

        //public virtual ProductEntity Product { get; set; }
    }
}
