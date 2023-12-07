using InventControl.Domain.Entities;
using InventControl.Domain.Interfaces.Infrastructure;
using InventControl.Infrastructure.Context;
using InventControl.Infrastructure.Repositories.Base;

namespace InventControl.Infrastructure.Repositories;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(InventControlContext context) : base(context)
    {
    }
}
