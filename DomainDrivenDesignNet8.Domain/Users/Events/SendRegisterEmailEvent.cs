
using MediatR;

namespace DomainDrivenDesignNet8.Domain.Users.Events;

public sealed class SendRegisterEmailEvent : INotificationHandler<UserDomainEvent>
{
    public Task Handle(UserDomainEvent notification, CancellationToken cancellationToken)
    {
        //email gönderme işlemleri
        return Task.CompletedTask;
    }
}
