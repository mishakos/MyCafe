using MyCafe.DB.Enities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository.Interfaces
{
    public interface IInvoiceDetailRepository
    {
        Task<InvoiceDetail> GetById(int id);
        Task<IEnumerable<InvoiceDetail>> GetAll();
        Task<int> Add(InvoiceDetail invoiceDetail);
        Task<int> Update(InvoiceDetail invoiceDetail);
        Task<int> Delete(InvoiceDetail invoiceDetail);
    }
}
