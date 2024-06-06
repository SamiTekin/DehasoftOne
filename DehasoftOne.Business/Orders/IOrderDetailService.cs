using DehasoftOne.Entity.Orders;

namespace DehasoftOne.Business.Orders
{
    public interface IOrderDetailService
    {
        Task<OrderDetail> AddOrderDetail(OrderDetail orderDetail);
        Task DeleteOrderDetail(Guid id);
        Task<OrderDetail> GetOrderDetail(Guid id);
        Task<List<OrderDetail>> GetOrderDetails();
        Task UpdateOrderDetail(OrderDetail orderDetail);
    }
}