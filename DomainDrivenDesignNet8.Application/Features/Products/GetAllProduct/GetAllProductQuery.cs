
using DomainDrivenDesignNet8.Domain.Products;
using MediatR;

namespace DomainDrivenDesignNet8.Application.Features.Products.GetAllProduct;

public sealed record GetAllProductQuery():IRequest<List<Product>>;
