
namespace DomainDrivenDesignNet8.Domain.Users;

public interface IUserRepository
{
    Task CreateAsync(string name, string surname, string email, 
                     string password, string phoneNumber, string country, string city, 
                     string street, string fullAddress, string postalCode, CancellationToken cancellationToken = default);
    Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default);
    //Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
