namespace WebMarket.EF.Entities
{
    public class SubCategoryEntity
    {
        public long SubCategoryId { get; set; }

        public long CategoryId { get; set; }

        public string Description { get; set; }

        public virtual CategoryEntity Category { get; set; }

    }
}
