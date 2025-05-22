
using MediatR;

namespace DomainDrivenDesignNet8.Domain.Orders.Events;

public sealed class SendOrderEmailEvent:INotificationHandler<OrderDomainEvent>
{
    public Task Handle(OrderDomainEvent notification, CancellationToken cancellationToken)
    {
        //email gönderme işlemleri
        return Task.CompletedTask;
    }
}
