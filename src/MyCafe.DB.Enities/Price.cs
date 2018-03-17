using System;

namespace MyCafe.DB.Enities
{
    public class Price
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PriceTypeId { get; set; }
        public PriceType PriceType { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ProductUnitId { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public decimal Amount { get; set; }

    }
}
