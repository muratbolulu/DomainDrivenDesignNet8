using DomainDrivenDesignNet8.Domain.Abstractions;
using DomainDrivenDesignNet8.Domain.Categories;

namespace DomainDrivenDesignNet8.Domain.Products;

public sealed class Product: Entity
{
    public Product(Guid id) : base(id)
    {
    }

    public string Name { get; set; }
    public int Quantitiy { get; set; }
    public decimal Price { get; set; }
    public string Currency { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
