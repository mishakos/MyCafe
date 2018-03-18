using Microsoft.EntityFrameworkCore;
using MyCafe.Db.Context;
using MyCafe.Db.Repository.Interfaces;
using MyCafe.DB.Enities;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository
{
    public class FirmRepository : IFirmRepository
    {
        private readonly MyCafeContext _context;

        public FirmRepository(MyCafeContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Firm firm)
        {
            _context.Add(firm);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(Firm firm)
        {
            _context.Remove(firm);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Firm>> GetAll()
        {
            return await _context.Firms.ToListAsync();
        }

        public async Task<Firm> GetById(int id)
        {
            return await _context.Firms.FindAsync(id);
        }

        public async Task<int> Update(Firm firm)
        {
            _context.Firms.Update(firm);
            return await _context.SaveChangesAsync();
        }
    }
}
