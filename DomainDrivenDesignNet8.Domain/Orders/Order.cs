using DomainDrivenDesignNet8.Domain.Abstractions;

namespace DomainDrivenDesignNet8.Domain.Orders;

public sealed class Order: Entity
{
    public Order(Guid id) : base(id)
    {
    }

    public string OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatusEnum Status { get; set; }
    public ICollection<OrderLines> OrderLines { get; set; }
}
