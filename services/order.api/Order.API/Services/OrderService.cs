using Order.API.Entities;
using Order.API.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Order.API.Hubs;

namespace Order.API.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IHubContext<OrderHub> _hubContext;

        public OrderService(IOrderRepository orderRepository, IHubContext<OrderHub> hubContext)
        {
            _orderRepository = orderRepository;
            _hubContext = hubContext;
        }

        public Task<IEnumerable<Order.API.Entities.Order>> GetAllOrdersAsync()
        {
            return _orderRepository.GetAllAsync();
        }

        public Task<Order.API.Entities.Order?> GetOrderByIdAsync(int id)
        {
            return _orderRepository.GetByIdAsync(id);
        }

        public async Task AddOrderAsync(Order.API.Entities.Order order)
        {
            await _orderRepository.AddAsync(order);
            
            var orderDto = new { id = order.Id, description = order.Description };
            await _hubContext.Clients.All.SendAsync("OrderCreated", orderDto);
        }

        public async Task NotifyOrderCreatedAsync(string orderInfo)
        {
            await _hubContext.Clients.All.SendAsync("OrderCreated", orderInfo);
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
