using MyCafe.DB.Enities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<Department> GetById(int id);
        Task<IEnumerable<Department>> GetAll();
        Task<IEnumerable<Department>> GetByFirmId(int firmId);
        Task<int> Add(Department department);
        Task<int> Update(Department department);
        Task<int> Delete(Department department);
    }
}
