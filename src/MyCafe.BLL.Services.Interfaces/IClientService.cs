using MyCafe.BLL.DTO;
using System.Threading.Tasks;

namespace MyCafe.BLL.Services.Interfaces
{
    public interface IClientService
    {
        Task<ClientDTO> GetClient(int id);
    }
}
