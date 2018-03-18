using MyCafe.DB.Enities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository.Interfaces
{
    public interface IFirmRepository
    {
        Task<Firm> GetById(int id);
        Task<IEnumerable<Firm>> GetAll();
        Task<int> Add(Firm firm);
        Task<int> Update(Firm firm);
        Task<int> Delete(Firm firm);

    }
}
