using InventControl.Application.DTO;

namespace InventControl.Application.Interfaces.Application;

public interface ICategoryApplication
{
    Task InsertAsync(CategoryDto category, CancellationToken cancellationToken);
    Task DeleteAsync(long Id, CancellationToken cancellationToken);
    Task<IEnumerable<CategoryDto>> GetAllAsync(CancellationToken cancellationToken);
    Task<CategoryDto> GetAsync(long Id, CancellationToken cancellationToken);
    Task UpdateAsync(CategoryDto category, CancellationToken cancellationToken);
}
