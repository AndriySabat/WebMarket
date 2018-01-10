namespace WebMarket.EF.Entities
{
    public class ProductCharacteristicEntity
    {
        public long CharacteristicId { get; set; }

        public long ProductId { get; set; }

        public string Description { get; set; }

        //public virtual ProductEntity Product { get; set; }
    }
}
