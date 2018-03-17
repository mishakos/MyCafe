namespace MyCafe.DB.Enities
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ProductUnitId { get; set; }
        public ProductUnit ProductUnit { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }

    }
}