
using MediatR;

namespace DomainDrivenDesignNet8.Domain.Orders.Events;

public sealed class SendSmsEmailEvent : INotificationHandler<OrderDomainEvent>
{
    public Task Handle(OrderDomainEvent notification, CancellationToken cancellationToken)
    {
        //sms gönderme işlemleri
        return Task.CompletedTask;
    }
}