﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyCafe.BLL.DTO
{
    public class OrderDetailDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public OrderDTO Order { get; set; }
        public int ProductId { get; set; }
        public ProductDTO Product { get; set; }
        public int ProductUnitId { get; set; }
        public ProductUnitDTO ProductUnit { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
    }
}
