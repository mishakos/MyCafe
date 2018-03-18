using Microsoft.EntityFrameworkCore;

using MyCafe.Db.Context;
using MyCafe.Db.Repository.Interfaces;
using MyCafe.DB.Enities;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyCafeContext _context;

        public ProductRepository(MyCafeContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Product product)
        {
            _context.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(Product product)
        {
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<int> Update(Product product)
        {
            _context.Products.Update(product);
            return await _context.SaveChangesAsync();
        }
    }
}
