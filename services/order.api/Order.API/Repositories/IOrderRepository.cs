using Order.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.API.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order.API.Entities.Order>> GetAllAsync();
        Task<Order.API.Entities.Order?> GetByIdAsync(int id);
        Task AddAsync(Order.API.Entities.Order order);
        Task UpdateAsync(Order.API.Entities.Order order);
        Task DeleteAsync(int id);
    }
}
