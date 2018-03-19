using System;
using System.Collections.Generic;
using System.Text;

namespace MyCafe.BLL.DTO
{
    public class RecipeDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public decimal Quantity { get; set; }
        public string Comments { get; set; }
        public decimal BruttoWeight { get; set; }
        public decimal NetWeight { get; set; }
        public IEnumerable<RecipeDetailDTO> RecipeDetails { get; set; }

    }
}
