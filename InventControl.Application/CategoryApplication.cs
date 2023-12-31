﻿using InventControl.Application.DTO;
using InventControl.Application.Interfaces.Application;
using InventControl.Domain.Entities;
using InventControl.Domain.Interfaces.Service;

namespace InventControl.Application;

public class CategoryApplication(ICategoryService categoryService) : ICategoryApplication
{
    public async Task InsertAsync(CategoryDto category, CancellationToken cancellationToken)
    {
        var obj = new Category
        {
            Avalible = category.Avalible,
            CategoryName = category.CategoryName
        };

        await categoryService.InsertAsync(obj, cancellationToken).ConfigureAwait(false);

    }

    public async Task<CategoryDto> GetAsync(long Id, CancellationToken cancellationToken)
    {
        var getById = await categoryService.GetAsync(Id, cancellationToken).ConfigureAwait(false);


        var result = getById != null ? new CategoryDto
        {
            Avalible = getById.Avalible,
            CategoryName = getById.CategoryName,
            Id = getById.Id
        } : new ();
        return result;
    }

    public async Task<IEnumerable<CategoryDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        var getAll = await categoryService.GetAllAsync(cancellationToken).ConfigureAwait(false);
        var result = new List<CategoryDto>();
        foreach (var item in getAll)
        {
            result.Add(new CategoryDto
            {
                Avalible = item.Avalible,
                CategoryName = item.CategoryName,
                Id = item.Id
            });
        }
        return result;
    }

    public async Task UpdateAsync(CategoryDto category, CancellationToken cancellationToken)
    {
        var obj = new Category
        {
            Id = category.Id,
            Avalible = category.Avalible,
            CategoryName = category.CategoryName
        };
        await categoryService.UpdateAsync(obj, cancellationToken).ConfigureAwait(false);
    }

    public async Task DeleteAsync(long Id, CancellationToken cancellationToken)
    {
        await categoryService.DeleteAsync(Id, cancellationToken).ConfigureAwait(false);
    }
}
