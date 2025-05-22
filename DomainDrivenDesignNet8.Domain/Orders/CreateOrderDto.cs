namespace DomainDrivenDesignNet8.Domain.Orders;

public sealed record CreateOrderDto(Guid ProductId, int Quantity, decimal Amount, string Currency);