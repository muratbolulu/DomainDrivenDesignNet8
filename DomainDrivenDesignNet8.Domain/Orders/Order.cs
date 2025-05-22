using DomainDrivenDesignNet8.Domain.Abstractions;
using DomainDrivenDesignNet8.Domain.Shared;

namespace DomainDrivenDesignNet8.Domain.Orders;

public sealed class Order : Entity
{
    public Order(Guid id, string orderNumber, DateTime orderDate, OrderStatusEnum status) : base(id)
    {
        OrderNumber = orderNumber;
        OrderDate = orderDate;
        Status = status;
    }

    public string OrderNumber { get; private set; }
    public DateTime OrderDate { get; private set; }
    public OrderStatusEnum Status { get; private set; }
    public ICollection<OrderLine> OrderLines { get; private set; }

    public void CreateOrder(List<CreateOrderDto> createOrderDtos)
    {
        foreach (var item in createOrderDtos)
        {
            if (item.Quantity < 1)
            {
                throw new ArgumentException("Quantity must be greater than 0");
            }

            //other validations

            OrderLine line = new OrderLine(
                                    Guid.NewGuid(),
                                    Id, item.ProductId,
                                    item.Quantity,
                                    new Money(item.Amount, Currency.FromCode(item.Currency)));

            OrderLines.Add(line);
        }
    }


    public void RemoveOrderLine(Guid orderLineId)
    {
        var orderline = OrderLines.FirstOrDefault(x => x.Id == orderLineId);
        if (orderline is null)
        {
            throw new ArgumentException("Order line not found");
        }
        OrderLines.Remove(orderline);
    }
}
