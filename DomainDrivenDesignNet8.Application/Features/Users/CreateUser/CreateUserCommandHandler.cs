using DomainDrivenDesignNet8.Domain.Abstractions;
using DomainDrivenDesignNet8.Domain.Users;
using DomainDrivenDesignNet8.Domain.Users.Events;
using MediatR;

namespace DomainDrivenDesignNet8.Application.Features.Users.CreateUser;

internal sealed class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMediator _mediator;
    public CreateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork, IMediator mediator)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
        _mediator = mediator;
    }

    public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        //business rules..

        var user = await _userRepository.CreateAsync(
            request.name,
            request.surname,
            request.email,
            request.password,
            request.country,
            request.city,
            request.street,
            request.fullAddress,
            request.postalCode,
            cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        await _mediator.Publish(new UserDomainEvent(user), cancellationToken);
    }
}

