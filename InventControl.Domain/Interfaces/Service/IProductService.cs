using InventControl.Domain.Entities;

namespace InventControl.Domain.Interfaces.Service
{
    public interface IProductService
    {
        Task DeleteAsync(long Id, CancellationToken cancellationToken);
        Task<IEnumerable<Product>> GetAllAsync(CancellationToken cancellationToken);
        Task<Product> GetAsync(long Id, CancellationToken cancellationToken);
        Task InsertAsync(Product product, CancellationToken cancellationToken);
        Task UpdateAsync(Product product, CancellationToken cancellationToken);
    }
}
