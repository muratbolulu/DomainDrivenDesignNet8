namespace DomainDrivenDesignNet8.Domain.Categories;

public interface ICategoryRepository
{
    Task CreateAsync(string name, CancellationToken cancellationToken = default);
    Task<List<Category>> GetAllAsync(CancellationToken cancellationToken = default);
    //Task<Category> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
