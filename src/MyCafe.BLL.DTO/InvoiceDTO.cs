using System;
using System.Collections.Generic;

namespace MyCafe.BLL.DTO
{
    public class InvoiceDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ClientId { get; set; }
        public ClientDTO Client { get; set; }
        public int DepartmentId { get; set; }
        public DepartmentDTO Department { get; set; }
        public IEnumerable<InvoiceDetailDTO> InvoiceDetails { get; set; }

    }
}
