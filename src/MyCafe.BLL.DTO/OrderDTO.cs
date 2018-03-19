using System;
using System.Collections.Generic;
using System.Text;

namespace MyCafe.BLL.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ClientId { get; set; }
        public ClientDTO Client { get; set; }
        public int TableId { get; set; }
        public TableDTO Table { get; set; }
        public IEnumerable<OrderDetailDTO> OrderDetails { get; set; }
    }
}
