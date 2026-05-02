using CleanArchitectureApi.Application.Interfaces;
using CleanArchitectureApi.Application.Products.Commands;
using MediatR;

namespace CleanArchitectureApi.Application.Products.Handlers;

public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
{
    private readonly IProductRepository _productRepository;

    public DeleteProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        return await _productRepository.DeleteAsync(request.Id);
    }
}