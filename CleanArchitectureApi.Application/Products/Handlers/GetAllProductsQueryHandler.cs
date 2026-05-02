using CleanArchitectureApi.Application.Interfaces;
using CleanArchitectureApi.Application.Products.Queries;
using CleanArchitectureApi.Domain.Entities;
using MediatR;

namespace CleanArchitectureApi.Application.Products.Handlers;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
{
    private readonly IProductRepository _productRepository;

    public GetAllProductsQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        return await _productRepository.GetAllAsync();
    }
}