using System;
using System.Collections.Generic;

namespace MyCafe.DB.Enities
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public IEnumerable<InvoiceDetail> InvoiceDetails { get; set; }

    }
}
