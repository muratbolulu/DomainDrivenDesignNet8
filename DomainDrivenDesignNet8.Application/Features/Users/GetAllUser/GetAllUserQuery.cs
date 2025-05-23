using DomainDrivenDesignNet8.Domain.Users;
using MediatR;

namespace DomainDrivenDesignNet8.Application.Features.Users.GetAllUser;

public sealed record GetAllUserQuery() : IRequest<List<User>>;
