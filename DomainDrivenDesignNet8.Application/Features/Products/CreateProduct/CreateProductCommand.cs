using DomainDrivenDesignNet8.Domain.Shared;
using MediatR;

namespace DomainDrivenDesignNet8.Application.Features.Products.CreateProduct;

public sealed record CreateProductCommand(string name, int quantity, decimal amount, string currency, Guid categoryId) : IRequest;
