using InventControl.Application.DTO;
using InventControl.Application.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;

namespace InventControl.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController(ICategoryApplication categoryApplication) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<CategoryDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await categoryApplication.GetAllAsync(cancellationToken).ConfigureAwait(false);
    }
    
    [HttpGet("{id}")]
    public async Task<CategoryDto> GetAllAsync(long id, CancellationToken cancellationToken)
    {
        return await categoryApplication.GetAsync(id, cancellationToken).ConfigureAwait(false);
    }
    
    [HttpPost]
    public async Task InsertAsync(CategoryDto dto, CancellationToken cancellationToken)
    {
        await categoryApplication.InsertAsync(dto, cancellationToken).ConfigureAwait(false);
    }

    [HttpPut]
    public async Task UpdateAsync(CategoryDto dto, CancellationToken cancellationToken)
    {
        await categoryApplication.UpdateAsync(dto, cancellationToken).ConfigureAwait(false);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(long id, CancellationToken cancellationToken)
    {
        await categoryApplication.DeleteAsync(id, cancellationToken).ConfigureAwait(false);
    }
}
