using System.Linq.Expressions;

namespace InventControl.Domain.Interfaces.Infrastructure
{
    public interface IRepository<TEntity>
    {
        Task <TEntity> Get(long id);
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> filter = null,
            Expression<Func<TEntity, object>> orderBy = null);
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(long id);
    }
}
