using MyCafe.BLL.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.BLL.Services.Interfaces
{
    public interface IClientService
    {
        Task<ClientDTO> GetClient(int id);
        Task<IEnumerable<ClientDTO>> GetClients();
        Task<int> AddClient(ClientDTO client);
        Task<int> UpdateClient(ClientDTO client);
        Task<int> DeleteClient(ClientDTO client);

    }
}
