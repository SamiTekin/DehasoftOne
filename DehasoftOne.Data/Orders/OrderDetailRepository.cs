using DehasoftOne.Data.Concrete;
using DehasoftOne.Data.Generics;
using DehasoftOne.Entity.Orders;

namespace DehasoftOne.Data.Orders;

public class OrderDetailRepository : GenericRepository<OrderDetail>
{
    private readonly OrderRepository _orderRepository;
    public OrderDetailRepository(DehasoftOneDbContext dbContext, OrderRepository orderRepository) : base(dbContext)
    {
        _orderRepository = orderRepository;
    }

    public new async Task<OrderDetail> AddAsync(OrderDetail orderDetail)
    {
        var result=await base.AddAsync(orderDetail);
        await _orderRepository.CalculateTotalPrice(orderDetail.OrderId);
        return result;
    }

    public new async Task<OrderDetail> UpdateAsync(OrderDetail orderDetail)
    {
        var result=await base.UpdateAsync(orderDetail);
        await _orderRepository.CalculateTotalPrice(orderDetail.OrderId);
        return result;
    }

    public new async Task DeleteAsync(Guid id)
    {
        OrderDetail orderDetail=await base.GetByIdAsync(id);
        await base.DeleteAsync(id);
        await _orderRepository.CalculateTotalPrice(orderDetail.OrderId);
    }
}
