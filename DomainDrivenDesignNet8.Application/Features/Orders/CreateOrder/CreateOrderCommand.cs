using DomainDrivenDesignNet8.Domain.Orders;
using MediatR;

namespace DomainDrivenDesignNet8.Application.Features.Orders.CreateOrder;

public sealed record CreateOrderCommand(List<CreateOrderDto> createOrderDtos) :IRequest;
