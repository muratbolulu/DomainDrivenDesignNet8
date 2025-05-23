
using DomainDrivenDesignNet8.Domain.Abstractions;
using DomainDrivenDesignNet8.Domain.Orders;
using DomainDrivenDesignNet8.Domain.Orders.Events;
using MediatR;

namespace DomainDrivenDesignNet8.Application.Features.Orders.CreateOrder;

internal sealed class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
{
    private readonly IOrderRepository _orderRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMediator _mediator;

    public CreateOrderCommandHandler(IOrderRepository orderRepository, IUnitOfWork unitOfWork, IMediator mediator)
    {
        _orderRepository = orderRepository;
        _unitOfWork = unitOfWork;
        _mediator = mediator;
    }

    public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = await _orderRepository.CreateAsync(request.createOrderDtos, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        //event i metiator e push eder.

        await _mediator.Publish(new OrderDomainEvent(order), cancellationToken);
    }
}