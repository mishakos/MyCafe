using MyCafe.BLL.DTO;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.BLL.Services.Interfaces
{
    public interface IDepartmentService
    {
        Task<DepartmentDTO> GetById(int id);
        Task<IEnumerable<DepartmentDTO>> GetAll();
        Task<IEnumerable<DepartmentDTO>> GetByFirmId(int firmId);
        Task<int> Add(DepartmentDTO department);
        Task<int> Update(DepartmentDTO department);
        Task<int> Delete(DepartmentDTO department);

    }
}
