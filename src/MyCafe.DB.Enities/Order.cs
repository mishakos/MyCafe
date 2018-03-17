using System;
using System.Collections.Generic;

namespace MyCafe.DB.Enities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }

    }
}
