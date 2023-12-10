using InventControl.Domain.Entities;

namespace InventControl.Domain.Interfaces.Service
{
    public interface ICategoryService
    {
        Task InsertAsync(Category category, CancellationToken token);
        Task DeleteAsync(long Id, CancellationToken cancellationToken);
        Task<IEnumerable<Category>> GetAllAsync(CancellationToken cancellationToken);
        Task<Category> GetAsync(long Id, CancellationToken cancellationToken);
        Task UpdateAsync(Category category, CancellationToken cancellationToken);
    }
}
