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
    public class OrderRepository : IOrderRepository
    {
        private readonly MyCafeContext _context;

        public OrderRepository(MyCafeContext context)
        {
            _context = context;
        }

        public async Task<int> Add(Order order)
        {
            await _context.AddAsync(order);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(Order order)
        {
            _context.Remove(order);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> GetById(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public async Task<int> Update(Order order)
        {
            _context.Update(order);
            return await _context.SaveChangesAsync();
        }
    }
}
