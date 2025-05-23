namespace DomainDrivenDesignNet8.Domain.Orders;

public interface IOrderRepository
{
    Task<Order> CreateAsync(List<CreateOrderDto> createOrderDtos, CancellationToken cancellationToken = default);
    Task<List<Order>> GetAllAsync(CancellationToken cancellationToken = default);
    //Task<Order> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
