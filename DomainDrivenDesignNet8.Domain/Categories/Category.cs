using DomainDrivenDesignNet8.Domain.Abstractions;
using DomainDrivenDesignNet8.Domain.Products;
using DomainDrivenDesignNet8.Domain.Shared;

namespace DomainDrivenDesignNet8.Domain.Categories;

public sealed class Category: Entity
{
    public Category(Guid id, Name name):base(id)
    {
        Name = name;
    }

    private Category(Guid id) : base(id)
    {
    }

    public Name Name { get; private set; }
    public ICollection<Product> Products { get; private set; }

    public void ChangeName(string name)
    {
        Name = new(name);
    }
}
