using MyCafe.DB.Enities;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository.Interfaces
{
    public interface IClientRepository
    {
        Task<Client> GetClientById(int id);
        Task<IEnumerable<Client>> GetClients();
        Task AddClient(Client client);
        Task UpdateClient(Client client);
        Task DeleteClient(Client client);
    }
}
