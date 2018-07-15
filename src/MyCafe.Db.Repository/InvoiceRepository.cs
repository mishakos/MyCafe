using Microsoft.EntityFrameworkCore;

using MyCafe.Db.Context;
using MyCafe.Db.Repository.Interfaces;
using MyCafe.DB.Enities;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly MyCafeContext _context;

        public InvoiceRepository(MyCafeContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Invoice product)
        {
            await _context.AddAsync(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(Invoice invoice)
        {
            _context.Remove(invoice);
            return await  _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Invoice>> GetAll()
        {
            return await _context.Invoices.ToListAsync();
        }

        public async Task<Invoice> GetById(int id)
        {
            return await _context.Invoices.FindAsync(id);
        }

        public async Task<int> Update(Invoice invoice)
        {
            _context.Invoices.Update(invoice);
            return await _context.SaveChangesAsync();
        }
    }
}
