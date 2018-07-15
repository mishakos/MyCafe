using MyCafe.DB.Enities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository.Interfaces
{
    public interface IInvoiceRepository
    {
        Task<Invoice> GetById(int id);
        Task<IEnumerable<Invoice>> GetAll();
        Task<int> Add(Invoice invoice);
        Task<int> Update(Invoice invoice);
        Task<int> Delete(Invoice invoice);
    }
}
