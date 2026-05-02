using CleanArchitectureApi.Domain.Entities;
using MediatR;

namespace CleanArchitectureApi.Application.Products.Commands;

public class CreateProductCommand : IRequest<Product>
{
    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int CategoryId { get; set; }
}