using InventControl.Application.DTO;

namespace InventControl.Application.Interfaces.Application;

public interface ICategoryApplication
{
    Task Insert(CategoryDto category, CancellationToken cancellationToken);
}
