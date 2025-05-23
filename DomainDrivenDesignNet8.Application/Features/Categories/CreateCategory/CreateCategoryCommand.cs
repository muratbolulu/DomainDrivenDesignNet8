using MediatR;

namespace DomainDrivenDesignNet8.Application.Features.Categories.CreateCategory;

public sealed record  CreateCategoryCommand(string name) :IRequest;
