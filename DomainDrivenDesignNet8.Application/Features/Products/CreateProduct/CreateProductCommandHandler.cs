using DomainDrivenDesignNet8.Domain.Abstractions;
using DomainDrivenDesignNet8.Domain.Categories;
using DomainDrivenDesignNet8.Domain.Products;
using MediatR;

namespace DomainDrivenDesignNet8.Application.Features.Products.CreateProduct;

internal sealed class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
{
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateProductCommandHandler(IProductRepository productRepository, 
                                       ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        //var category = await _categoryRepository.GetByIdAsync(request.categoryId, cancellationToken);
        //if (category == null)
        //{
        //    throw new NotFoundException("Category not found");
        //}
        //var product = new Product(request.name, request.description, request.price, request.stockQuantity, category);
        await _productRepository.CreateAsync(request.name, request.quantity, request.amount, request.currency, request.categoryId, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}