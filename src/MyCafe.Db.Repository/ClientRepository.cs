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

        public async Task AddClient(Client client)
        {
            _context.Add(client);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClient(Client client)
        {
            var oldItem = _context.Clients.FindAsync(client.Id);
            if (oldItem == null) throw new ArgumentException($"Client {client.Id} not found.");
            _context.Remove(client);
            await _context.SaveChangesAsync();
        }

        public async Task<Client> GetClientById(int id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task<IEnumerable<Client>> GetClients()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task UpdateClient(Client client)
        {
            _context.Update(client);
            await _context.SaveChangesAsync();
        }
    }
}
