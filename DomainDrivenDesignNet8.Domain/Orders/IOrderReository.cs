namespace DomainDrivenDesignNet8.Domain.Orders;

public interface IOrderReository
{
    Task CreateAsync(List<CreateOrderDto> createOrderDtos, CancellationToken cancellationToken = default);
    Task<List<Order>> GetAllAsync(CancellationToken cancellationToken = default);
    //Task<Order> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
