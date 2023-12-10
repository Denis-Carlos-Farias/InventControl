using InventControl.Domain.Entities;
using InventControl.Domain.Interfaces.Infrastructure;
using InventControl.Domain.Interfaces.Service;

namespace InventControl.Service;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _repository;
    public CategoryService(ICategoryRepository repository)
    {
        _repository = repository;
    }
    public async Task InsertAsync(Category category, CancellationToken cancellationToken)
    {
        await _repository.InsertAsync(category, cancellationToken).ConfigureAwait(false);
    }
    public async Task<Category> GetAsync(long Id, CancellationToken cancellationToken)
    {
        return await _repository.GetAsync(Id, cancellationToken).ConfigureAwait(false);
    }
    public async Task<IEnumerable<Category>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _repository.GetAsync(cancellationToken).ConfigureAwait(false);
    }
    public async Task UpdateAsync(Category category, CancellationToken cancellationToken)
    {
        await _repository.UpdateAsync(category, cancellationToken).ConfigureAwait(false);
    }
    public async Task DeleteAsync(long Id, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(Id, cancellationToken).ConfigureAwait(false);
    }

}
