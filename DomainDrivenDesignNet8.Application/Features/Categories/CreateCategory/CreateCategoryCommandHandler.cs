
using DomainDrivenDesignNet8.Domain.Abstractions;
using DomainDrivenDesignNet8.Domain.Categories;
using MediatR;

namespace DomainDrivenDesignNet8.Application.Features.Categories.CreateCategory;

internal sealed class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;
    public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
    {
        _categoryRepository = categoryRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        await _categoryRepository.CreateAsync(request.name, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
