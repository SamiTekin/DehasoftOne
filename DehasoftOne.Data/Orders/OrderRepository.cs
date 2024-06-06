using DehasoftOne.Data.Concrete;
using DehasoftOne.Data.Generics;
using DehasoftOne.Entity.Order;
using DehasoftOne.Entity.Orders;

namespace DehasoftOne.Data.Orders;

public class OrderRepository : GenericRepository<Order>
{
    public OrderRepository(DehasoftOneDbContext dbContext) : base(dbContext)
    {
    }

    public async Task CalculateTotalPrice(Guid orderId)
    {
        Order order = _dbContext.Set<Order>().FirstOrDefault(x => x.Id == orderId);
        order.TotalPrice= _dbContext.Set<OrderDetail>().Where(x => x.OrderId == orderId).Sum(x => x.TotalPrice);
        await _dbContext.SaveChangesAsync();
    }
}
