using DomainDrivenDesignNet8.Domain.Abstractions;
using DomainDrivenDesignNet8.Domain.Products;

namespace DomainDrivenDesignNet8.Domain.Orders;

public sealed class OrderLines: Entity
{
    public OrderLines(Guid id) : base(id)
    {
    }

    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public string Currency { get; set; }

}