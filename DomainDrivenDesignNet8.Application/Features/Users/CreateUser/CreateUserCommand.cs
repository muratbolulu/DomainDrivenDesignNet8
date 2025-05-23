using MediatR;

namespace DomainDrivenDesignNet8.Application.Features.Users.CreateUser;

public sealed record CreateUserCommand(string name, string surname, string email,
                     string password, string phoneNumber, string country, string city,
                     string street, string fullAddress, string postalCode) :IRequest;

