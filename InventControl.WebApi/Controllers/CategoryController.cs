using InventControl.Application.DTO;
using InventControl.Application.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;

namespace InventControl.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryApplication _categoryApplication;

    public CategoryController(ICategoryApplication categoryApplication)
    {
        _categoryApplication = categoryApplication;
    }

    [HttpGet]
    public async Task<IEnumerable<CategoryDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _categoryApplication.GetAllAsync(cancellationToken).ConfigureAwait(false);
    }
    
    [HttpGet("{id}")]
    public async Task<CategoryDto> GetAllAsync(long id, CancellationToken cancellationToken)
    {
        return await _categoryApplication.GetAsync(id, cancellationToken).ConfigureAwait(false);
    }
    
    [HttpPost]
    public async Task InsertAsync(CategoryDto dto, CancellationToken cancellationToken)
    {
        await _categoryApplication.InsertAsync(dto, cancellationToken).ConfigureAwait(false);
    }

    [HttpPut]
    public async Task UpdateAsync(CategoryDto dto, CancellationToken cancellationToken)
    {
        await _categoryApplication.UpdateAsync(dto, cancellationToken).ConfigureAwait(false);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(long id, CancellationToken cancellationToken)
    {
        await _categoryApplication.DeleteAsync(id, cancellationToken).ConfigureAwait(false);
    }
}
