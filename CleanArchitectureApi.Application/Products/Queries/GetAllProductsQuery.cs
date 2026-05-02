using CleanArchitectureApi.Domain.Entities;
using MediatR;

namespace CleanArchitectureApi.Application.Products.Queries;

public class GetAllProductsQuery : IRequest<List<Product>>
{
}