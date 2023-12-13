using System.Linq.Expressions;

namespace InventControl.Domain.Interfaces.Infrastructure
{
    public interface IRepository<TEntity>
    {
        Task <TEntity> GetAsync(long id, CancellationToken cancellationToken);
        Task<IEnumerable<TEntity>> GetAsync(CancellationToken cancellationToken, Expression<Func<TEntity, bool>>? filter = null,
            Expression<Func<TEntity, object>>? orderBy = null);
        Task InsertAsync(TEntity entity, CancellationToken cancellationToken);
        Task UpdateAsync(TEntity entity, CancellationToken cancellationToken);
        Task DeleteAsync(long id, CancellationToken cancellationToken);
    }
}
