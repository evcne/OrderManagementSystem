using Order.API.Entities;
using Order.API.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.API.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Task<IEnumerable<Order.API.Entities.Order>> GetAllOrdersAsync()
        {
            return _orderRepository.GetAllAsync();
        }

        public Task<Order.API.Entities.Order?> GetOrderByIdAsync(int id)
        {
            return _orderRepository.GetByIdAsync(id);
        }

        public Task AddOrderAsync(Order.API.Entities.Order order)
        {
            return _orderRepository.AddAsync(order);
        }

        public Task UpdateOrderAsync(Order.API.Entities.Order order)
        {
            return _orderRepository.UpdateAsync(order);
        }

        public Task DeleteOrderAsync(int id)
        {
            return _orderRepository.DeleteAsync(id);
        }
    }
}
