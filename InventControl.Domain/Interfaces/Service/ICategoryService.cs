using InventControl.Domain.DTO;

namespace InventControl.Domain.Interfaces.Service
{
    public interface ICategoryService
    {
        Task Insert(CategoryDto category);
    }
}
