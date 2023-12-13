using InventControl.Domain.Entities;
using InventControl.Domain.Interfaces.Infrastructure;
using InventControl.Domain.Interfaces.Service;

namespace InventControl.Service;

public class CategoryService(ICategoryRepository repository) : ICategoryService
{
    public async Task InsertAsync(Category category, CancellationToken cancellationToken)
    {
        await repository.InsertAsync(category, cancellationToken).ConfigureAwait(false);
    }
    public async Task<Category> GetAsync(long Id, CancellationToken cancellationToken)
    {
        return await repository.GetAsync(Id, cancellationToken).ConfigureAwait(false);
    }
    public async Task<IEnumerable<Category>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await repository.GetAsync(cancellationToken).ConfigureAwait(false);
    }
    public async Task UpdateAsync(Category category, CancellationToken cancellationToken)
    {
        await repository.UpdateAsync(category, cancellationToken).ConfigureAwait(false);
    }
    public async Task DeleteAsync(long Id, CancellationToken cancellationToken)
    {
        await repository.DeleteAsync(Id, cancellationToken).ConfigureAwait(false);
    }

}
