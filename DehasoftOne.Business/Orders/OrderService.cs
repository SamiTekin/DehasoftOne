using DehasoftOne.Data.Orders;
using DehasoftOne.Entity.Order;

namespace DehasoftOne.Business.Orders;

public class OrderService : IOrderService
{
    private readonly OrderRepository _orderRepository;
    public OrderService(OrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<Order> AddOrder(Order order)
    {
        return await _orderRepository.AddAsync(order);
    }

    public async Task UpdateOrder(Order order)
    {
        await _orderRepository.UpdateAsync(order);
    }

    public async Task DeleteOrder(Guid id)
    {
        await _orderRepository.DeleteAsync(id);
    }
    public async Task<List<Order>> GetOrders()
    {
        return _orderRepository.GetAll().ToList();
    }

    public async Task<Order> GetOrder(Guid id)
    {
        return await _orderRepository.GetByIdAsync(id);
    }
}
