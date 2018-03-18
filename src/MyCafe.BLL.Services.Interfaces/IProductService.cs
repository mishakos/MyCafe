using MyCafe.BLL.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCafe.BLL.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductDTO> GetById(int id);
        Task<IEnumerable<ProductDTO>> GetAll();
        Task<int> Add(ProductDTO product);
        Task<int> Update(ProductDTO product);
        Task<int> Delete(ProductDTO product);
    }
}
