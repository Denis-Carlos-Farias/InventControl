using InventControl.Domain.DTO;
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
    public async Task Insert(CategoryDto category, CancellationToken cancellationToken)
    {
        var obj = new Category
        {
            Avalible = category.Avalible,
            CategoryName = category.CategoryName
        };
        await _repository.Insert(obj, cancellationToken).ConfigureAwait(false);
    }
}
