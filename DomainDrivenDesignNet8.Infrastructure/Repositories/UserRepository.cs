using DomainDrivenDesignNet8.Domain.Users;
using DomainDrivenDesignNet8.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesignNet8.Infrastructure.Repositories;

internal sealed class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<User> CreateAsync(string name, string surname, string email, string password, string country, string city, string street, string fullAddress, string postalCode, CancellationToken cancellationToken = default)
    {
        User user = User.CreateUser(name, surname, email, password, country, city, street, fullAddress, postalCode);

        await _context.AddAsync(user, cancellationToken);

        return user;
    }

    public Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return _context.Users.AsNoTracking()
            .ToListAsync(cancellationToken);
    }
}
