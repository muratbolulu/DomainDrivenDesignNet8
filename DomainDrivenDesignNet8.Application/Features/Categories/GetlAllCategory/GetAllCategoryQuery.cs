using DomainDrivenDesignNet8.Domain.Categories;
using MediatR;

namespace DomainDrivenDesignNet8.Application.Features.Categories.GetlAllCategory;

public sealed record GetAllCategoryQuery() : IRequest<List<Category>>;
