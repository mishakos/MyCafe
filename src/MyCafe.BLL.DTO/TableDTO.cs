using System;
using System.Collections.Generic;
using System.Text;

namespace MyCafe.BLL.DTO
{
    public class TableDTO
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public DepartmentDTO Department { get; set; }
        public string Name { get; set; }
    }
}
