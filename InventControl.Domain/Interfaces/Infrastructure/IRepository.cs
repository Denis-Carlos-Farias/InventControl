using System.Linq.Expressions;

namespace InventControl.Domain.Interfaces.Infrastructure
{
    public interface IRepository<TEntity>
    {
        Task <TEntity> Get(long id, CancellationToken cancellationToken);
        Task<IEnumerable<TEntity>> Get(CancellationToken cancellationToken, Expression<Func<TEntity, bool>> filter = null,
            Expression<Func<TEntity, object>> orderBy = null);
        Task Insert(TEntity entity, CancellationToken cancellationToken);
        Task Update(TEntity entity, CancellationToken cancellationToken);
        Task Delete(long id, CancellationToken cancellationToken);
    }
}
