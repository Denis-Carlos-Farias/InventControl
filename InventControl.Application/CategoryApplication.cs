using InventControl.Application.DTO;
using InventControl.Application.Interfaces.Application;
using InventControl.Domain.Entities;
using InventControl.Domain.Interfaces.Service;

namespace InventControl.Application;

public class CategoryApplication : ICategoryApplication
{
    private readonly ICategoryService _categoryService;

    public CategoryApplication(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    public async Task Insert(CategoryDto category, CancellationToken cancellationToken)
    {
        var obj = new Category
        {
            Avalible = category.Avalible,
            CategoryName = category.CategoryName
        };

        await _categoryService.Insert(obj, cancellationToken).ConfigureAwait(false);

    }
}
