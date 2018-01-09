namespace WebMarket.EF.Entities
{
    public class SubCategoryEntity
    {
        public int SubCategoryId { get; set; }

        public int CategoryId { get; set; }

        public string Description { get; set; }

        public virtual CategoryEntity Category { get; set; }

    }
}
