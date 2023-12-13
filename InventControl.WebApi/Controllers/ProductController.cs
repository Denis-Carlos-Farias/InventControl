using InventControl.Application.DTO;
using InventControl.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InventControl.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController(IProductApplication productApplication) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<ProductDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await productApplication.GetAllAsync(cancellationToken).ConfigureAwait(false);
    }

    [HttpGet("{id}")]
    public async Task<ProductDto> GetAllAsync(long id, CancellationToken cancellationToken)
    {
        return await productApplication.GetAsync(id, cancellationToken).ConfigureAwait(false);
    }

    [HttpPost]
    public async Task InsertAsync(ProductDto dto, CancellationToken cancellationToken)
    {
        await productApplication.InsertAsync(dto, cancellationToken).ConfigureAwait(false);
    }

    [HttpPut]
    public async Task UpdateAsync(ProductDto dto, CancellationToken cancellationToken)
    {
        await productApplication.UpdateAsync(dto, cancellationToken).ConfigureAwait(false);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(long id, CancellationToken cancellationToken)
    {
        await productApplication.DeleteAsync(id, cancellationToken).ConfigureAwait(false);
    }
}
