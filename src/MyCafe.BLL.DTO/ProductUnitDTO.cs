namespace MyCafe.BLL.DTO
{
    public class ProductUnitDTO
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public UnitDTO Unit { get; set; }
        public int ProductId { get; set; }
        public ProductDTO Product { get; set; }
        public decimal Koef { get; set; }
        public decimal Weight { get; set; }
        public int WightUnitId { get; set; }
        public UnitDTO WeightUnit { get; set; }
    }
}
