using MyCafe.DB.Enities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCafe.Db.Repository.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> GetById(int id);
        Task<IEnumerable<Order>> GetAll();
        Task<int> Add(Order order);
        Task<int> Update(Order order);
        Task<int> Delete(Order order);
    }
}
