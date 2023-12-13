using InventControl.Application.DTO;

namespace InventControl.Application.Interfaces;

public interface IProductApplication
{
    Task DeleteAsync(long Id, CancellationToken cancellationToken);
    Task<IEnumerable<ProductDto>> GetAllAsync(CancellationToken cancellationToken);
    Task<ProductDto> GetAsync(long Id, CancellationToken cancellationToken);
    Task InsertAsync(ProductDto product, CancellationToken cancellationToken);
    Task UpdateAsync(ProductDto product, CancellationToken cancellationToken);
}
