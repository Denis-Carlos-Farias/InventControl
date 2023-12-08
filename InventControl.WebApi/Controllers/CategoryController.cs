using InventControl.Domain.DTO;
using InventControl.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace InventControl.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task Insert(CategoryDto dto, CancellationToken cancellationToken)
        {
            await _categoryService.Insert(dto, cancellationToken).ConfigureAwait(false);
        }
    }
}
