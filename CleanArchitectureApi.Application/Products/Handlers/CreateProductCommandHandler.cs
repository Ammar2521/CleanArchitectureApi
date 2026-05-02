using CleanArchitectureApi.Application.Interfaces;
using CleanArchitectureApi.Application.Products.Commands;
using CleanArchitectureApi.Domain.Entities;
using MediatR;

namespace CleanArchitectureApi.Application.Products.Handlers;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
{
    private readonly IProductRepository _productRepository;

    public CreateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Name = request.Name,
            Price = request.Price,
            CategoryId = request.CategoryId
        };

        return await _productRepository.AddAsync(product);
    }
}