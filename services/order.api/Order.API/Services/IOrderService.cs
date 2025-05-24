using Order.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.API.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order.API.Entities.Order>> GetAllOrdersAsync();
        Task<Order.API.Entities.Order?> GetOrderByIdAsync(int id);
        Task AddOrderAsync(Order.API.Entities.Order order);
        Task UpdateOrderAsync(Order.API.Entities.Order order);
        Task DeleteOrderAsync(int id);
    }
}
