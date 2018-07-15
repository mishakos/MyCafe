using Microsoft.EntityFrameworkCore;

using MyCafe.Db.Context;
using MyCafe.Db.Repository.Interfaces;
using MyCafe.DB.Enities;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository
{
    public class InvoiceDetailRepository : IInvoiceDetailRepository
    {
        private readonly MyCafeContext _context;

        public InvoiceDetailRepository(MyCafeContext context)
        {
            _context = context;
        }

        public async Task<int> Add(InvoiceDetail invoiceDetail)
        {
            await _context.AddAsync(invoiceDetail);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(InvoiceDetail invoiceDetail)
        {
            _context.Remove(invoiceDetail);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<InvoiceDetail>> GetAll()
        {
            return await _context.InvoiceDetails.ToListAsync();
        }

        public async Task<InvoiceDetail> GetById(int id)
        {
            return await _context.InvoiceDetails.FindAsync(id);
        }

        public async Task<int> Update(InvoiceDetail invoiceDetail)
        {
            _context.InvoiceDetails.Update(invoiceDetail);
            return await _context.SaveChangesAsync();
        }
    }
}
