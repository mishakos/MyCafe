using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCafe.Web.ViewModels
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        public int FirmId { get; set; }
        public FirmViewModel Firm { get; set; }
        public string Name { get; set; }

    }
}
