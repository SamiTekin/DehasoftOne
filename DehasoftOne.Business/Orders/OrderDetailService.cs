using DehasoftOne.Data.Orders;
using DehasoftOne.Entity.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DehasoftOne.Business.Orders;

public class OrderDetailService : IOrderDetailService
{
    private readonly OrderDetailRepository _orderDetailRepository;
    public OrderDetailService(OrderDetailRepository orderDetailRepository)
    {
        _orderDetailRepository = orderDetailRepository;
    }

    public async Task<OrderDetail> AddOrderDetail(OrderDetail orderDetail)
    {
        return await _orderDetailRepository.AddAsync(orderDetail);
    }

    public async Task UpdateOrderDetail(OrderDetail orderDetail)
    {
        await _orderDetailRepository.UpdateAsync(orderDetail);
    }

    public async Task DeleteOrderDetail(Guid id)
    {
        await _orderDetailRepository.DeleteAsync(id);
    }
    public async Task<List<OrderDetail>> GetOrderDetails()
    {
        return _orderDetailRepository.GetAll().ToList();
    }

    public async Task<OrderDetail> GetOrderDetail(Guid id)
    {
        return await _orderDetailRepository.GetByIdAsync(id);
    }
}
