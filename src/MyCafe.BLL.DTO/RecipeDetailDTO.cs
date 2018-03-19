namespace MyCafe.BLL.DTO
{
    public class RecipeDetailDTO
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public RecipeDTO Recipe { get; set; }
        public int ProductId { get; set; }
        public ProductDTO Product { get; set; }
        public int ProductUnitId { get; set; }
        public ProductUnitDTO ProductUnit { get; set; }
        public decimal Quantity { get; set; }
        public decimal BruttoWeight { get; set; }
        public decimal NetWeight { get; set; }

    }
}