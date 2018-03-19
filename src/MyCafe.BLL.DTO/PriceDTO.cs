using System;

namespace MyCafe.BLL.DTO
{
    public class PriceDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PriceTypeId { get; set; }
        public PriceTypeDTO PriceType { get; set; }
        public int ProductId { get; set; }
        public ProductDTO Product { get; set; }
        public int ProductUnitId { get; set; }
        public ProductUnitDTO ProductUnit { get; set; }
        public decimal Amount { get; set; }
    }
}
