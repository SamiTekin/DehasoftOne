using DehasoftOne.Entity.Order;

namespace DehasoftOne.Business.Orders
{
    public interface IOrderService
    {
        Task<Order> AddOrder(Order order);
        Task DeleteOrder(Guid id);
        Task<Order> GetOrder(Guid id);
        Task<List<Order>> GetOrders();
        Task UpdateOrder(Order order);
    }
}