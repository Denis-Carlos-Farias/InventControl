using InventControl.Domain.Entities;
using InventControl.Domain.Interfaces.Infrastructure;
using InventControl.Domain.Interfaces.Service;

namespace InventControl.Service;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }
    public async Task InsertAsync(Product product, CancellationToken cancellationToken)
    {
        await _repository.InsertAsync(product, cancellationToken).ConfigureAwait(false);
    }
    public async Task<Product> GetAsync(long Id, CancellationToken cancellationToken)
    {
        return await _repository.GetAsync(Id, cancellationToken).ConfigureAwait(false);
    }
    public async Task<IEnumerable<Product>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _repository.GetAsync(cancellationToken).ConfigureAwait(false);
    }
    public async Task UpdateAsync(Product product, CancellationToken cancellationToken)
    {
        await _repository.UpdateAsync(product, cancellationToken).ConfigureAwait(false);
    }
    public async Task DeleteAsync(long Id, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(Id, cancellationToken).ConfigureAwait(false);
    }
}
