using MyCafe.BLL.DTO;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.BLL.Services.Interfaces
{
    public interface IFirmService
    {
        Task<FirmDTO> GetById(int id);
        Task<IEnumerable<FirmDTO>> GetAll();
        Task<int> Add(FirmDTO firm);
        Task<int> Update(FirmDTO firm);
        Task<int> Delete(FirmDTO firm);

    }
}
