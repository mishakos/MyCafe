using MyCafe.DB.Enities;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository.Interfaces
{
    public interface IProductUnitRepository
    {
        Task<IEnumerable<ProductUnit>> GetByProductId(int id);
        Task<ProductUnit> GetById(int id);
        Task<int> Add(ProductUnit productUnit);
        Task<int> Update(ProductUnit productUnit);
        Task<int> Delete(ProductUnit productUnit);
    }
}
