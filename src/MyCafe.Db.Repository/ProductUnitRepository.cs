using Microsoft.EntityFrameworkCore;
using MyCafe.Db.Context;
using MyCafe.Db.Repository.Interfaces;
using MyCafe.DB.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository
{
    public class ProductUnitRepository : IProductUnitRepository
    {
        private readonly MyCafeContext _context;

        public ProductUnitRepository(MyCafeContext context)
        {
            _context = context;
        }

        public async Task<int> Add(ProductUnit productUnit)
        {
            _context.Add(productUnit);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(ProductUnit productUnit)
        {
            _context.ProductUnits.Remove(productUnit);
            return await _context.SaveChangesAsync();
        }

        public async Task<ProductUnit> GetById(int id)
        {
            return await _context.ProductUnits.FindAsync(id);
        }

        public async Task<IEnumerable<ProductUnit>> GetByProductId(int id)
        {
            return await _context.ProductUnits.Where(p => p.ProductId == id).ToListAsync();
        }

        public async Task<int> Update(ProductUnit productUnit)
        {
            _context.ProductUnits.Update(productUnit);
            return await _context.SaveChangesAsync();
        }
    }
}
