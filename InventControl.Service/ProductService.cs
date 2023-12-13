using InventControl.Domain.Entities;
using InventControl.Domain.Interfaces.Infrastructure;
using InventControl.Domain.Interfaces.Service;

namespace InventControl.Service;

public class ProductService(IProductRepository repository) : IProductService
{
    public async Task InsertAsync(Product product, CancellationToken cancellationToken)
    {
        await repository.InsertAsync(product, cancellationToken).ConfigureAwait(false);
    }
    public async Task<Product> GetAsync(long Id, CancellationToken cancellationToken)
    {
        return await repository.GetAsync(Id, cancellationToken).ConfigureAwait(false);
    }
    public async Task<IEnumerable<Product>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await repository.GetAsync(cancellationToken).ConfigureAwait(false);
    }
    public async Task UpdateAsync(Product product, CancellationToken cancellationToken)
    {
        await repository.UpdateAsync(product, cancellationToken).ConfigureAwait(false);
    }
    public async Task DeleteAsync(long Id, CancellationToken cancellationToken)
    {
        await repository.DeleteAsync(Id, cancellationToken).ConfigureAwait(false);
    }
}
