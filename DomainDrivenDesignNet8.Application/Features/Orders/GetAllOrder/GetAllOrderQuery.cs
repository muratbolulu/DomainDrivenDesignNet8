using DomainDrivenDesignNet8.Domain.Orders;
using MediatR;

namespace DomainDrivenDesignNet8.Application.Features.Orders.GetAllOrder;

public sealed record GetAllOrderQuery:IRequest<List<Order>>;
