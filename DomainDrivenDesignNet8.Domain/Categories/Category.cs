using DomainDrivenDesignNet8.Domain.Abstractions;
using DomainDrivenDesignNet8.Domain.Products;

namespace DomainDrivenDesignNet8.Domain.Categories;

public sealed class Category: Entity
{
    public Category(Guid id) : base(id)
    {
    }

    public string Name { get; set; }
    public ICollection<Product> Products { get; set; }
}
