using Microsoft.EntityFrameworkCore;

using MyCafe.Db.Context;
using MyCafe.Db.Repository.Interfaces;
using MyCafe.DB.Enities;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly MyCafeContext _context;

        public ClientRepository(MyCafeContext context)
        {
            _context = context;
        }

        public async Task<int> AddClient(Client client)
        {
            _context.Add(client);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteClient(Client client)
        {
            var oldItem = _context.Clients.FindAsync(client.Id);
            if (oldItem == null) throw new ArgumentException($"Client {client.Id} not found.");
            _context.Remove(client);
            return await _context.SaveChangesAsync();
        }

        public async Task<Client> GetClientById(int id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task<IEnumerable<Client>> GetClients()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<int> UpdateClient(Client client)
        {
            _context.Update(client);
            return await _context.SaveChangesAsync();
        }
    }
}
