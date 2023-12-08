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

    [HttpPost]
    public async Task Insert(CategoryDto dto, CancellationToken cancellationToken)
    {
        await _categoryApplication.Insert(dto, cancellationToken).ConfigureAwait(false);
    }
}
