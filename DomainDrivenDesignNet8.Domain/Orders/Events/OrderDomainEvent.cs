﻿using MediatR;

namespace DomainDrivenDesignNet8.Domain.Orders.Events;

public sealed class OrderDomainEvent : INotification
{
    public Order Order { get; }

    public OrderDomainEvent(Order order)
    {
        Order = order;
    }
}
