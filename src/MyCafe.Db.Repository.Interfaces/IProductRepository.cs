using MyCafe.DB.Enities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetById(int id);
        Task<IEnumerable<Product>> GetAll();
        Task<int> Add(Product product);
        Task<int> Update(Product product);
        Task<int> Delete(Product product);
    }
}
