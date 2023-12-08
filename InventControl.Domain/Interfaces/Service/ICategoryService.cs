using InventControl.Domain.Entities;

namespace InventControl.Domain.Interfaces.Service
{
    public interface ICategoryService
    {
        Task Insert(Category category, CancellationToken token);
    }
}
