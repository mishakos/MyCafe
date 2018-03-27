using System.ComponentModel.DataAnnotations.Schema;

namespace MyCafe.DB.Enities
{
    public class ProductUnit
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal Koef { get; set; }
        public decimal Weight { get; set; }
        public int WeightUnitId { get; set; }
        [ForeignKey("WeightUnitId")]
        public Unit WeightUnit { get; set; }
    }
}
