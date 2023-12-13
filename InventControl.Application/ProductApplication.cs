using InventControl.Application.DTO;
using InventControl.Application.Interfaces;
using InventControl.Domain.Entities;
using InventControl.Domain.Interfaces.Service;

namespace InventControl.Application;

public class ProductApplication(IProductService productService) : IProductApplication
{
    public async Task InsertAsync(ProductDto product, CancellationToken cancellationToken)
    {
        var obj = new Product
        {
            CategoryId = product.CategoryId,
            Name = product.Name,
            Id = product.Id,
            Description = product.Description,
            Discount = product.Discount,
            Price = product.Price,
            Quantity = product.Quantity
        };

        await productService.InsertAsync(obj, cancellationToken).ConfigureAwait(false);

    }

    public async Task<ProductDto> GetAsync(long Id, CancellationToken cancellationToken)
    {
        var product = await productService.GetAsync(Id, cancellationToken).ConfigureAwait(false);

        var result = product != null ? new ProductDto
        {
            CategoryId = product.CategoryId,
            Name = product.Name,
            Id = product.Id,
            Description = product.Description,
            Discount = product.Discount,
            Price = product.Price,
            Quantity = product.Quantity
        } : new();
        return result;
    }

    public async Task<IEnumerable<ProductDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        var getAll = await productService.GetAllAsync(cancellationToken).ConfigureAwait(false);
        var result = new List<ProductDto>();
        foreach (var item in getAll)
        {
            result.Add(new ProductDto
            {
                CategoryId = item.CategoryId,
                Name = item.Name,
                Id = item.Id,
                Description = item.Description,
                Discount = item.Discount,
                Price = item.Price,
                Quantity = item.Quantity
            });
        }
        return result;
    }

    public async Task UpdateAsync(ProductDto product, CancellationToken cancellationToken)
    {
        var obj = new Product
        {
            Id = product.Id,
            Description = product.Description,
            CategoryId = product.CategoryId,
            Discount = product.Discount,
            Name = product.Name,
            Price = product.Price,
            Quantity = product.Quantity,
        };
        await productService.UpdateAsync(obj, cancellationToken).ConfigureAwait(false);
    }

    public async Task DeleteAsync(long Id, CancellationToken cancellationToken)
    {
        await productService.DeleteAsync(Id, cancellationToken).ConfigureAwait(false);
    }
}
