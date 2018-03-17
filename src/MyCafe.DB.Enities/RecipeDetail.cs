namespace MyCafe.DB.Enities
{
    public class RecipeDetail
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ProductUnitId { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public decimal Quantity { get; set; }
        public decimal BruttoWeight { get; set; }
        public decimal NetWeight { get; set; }

    }
}
