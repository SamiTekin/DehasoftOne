using DehasoftOne.Entity.BaseEntities;
using DehasoftOne.Entity.Enums;

namespace DehasoftOne.Entity.Order;

public class Order : BaseEntity
{
    public Guid OrdererId { get; set; }
    public DateTime OrderDate { get; set; }
    public string Description { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Onaylandı;
    public decimal? TotalPrice { get; set; }
}
