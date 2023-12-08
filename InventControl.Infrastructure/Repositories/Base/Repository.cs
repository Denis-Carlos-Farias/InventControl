
using InventControl.Domain.Entities;
using InventControl.Domain.Interfaces.Infrastructure;
using InventControl.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace InventControl.Infrastructure.Repositories.Base;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
{
    protected readonly InventControlContext _context;
    public Repository(InventControlContext context)
    {
        _context = context;
    }
    public async Task<TEntity> Get(long id, CancellationToken cancellationToken)
    {
        try
        {
            return await _context.Set<TEntity>().AsNoTracking().Where(p => p.Id == id).SingleOrDefaultAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
    public async Task<IEnumerable<TEntity>> Get(CancellationToken cancellationToken, Expression<Func<TEntity, bool>> filter = null,
        Expression<Func<TEntity, object>> orderBy = null)
    {
        try
        {
            return await _context.Set<TEntity>().AsNoTracking().Where(filter).OrderBy(orderBy).ToListAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public async Task Insert(TEntity entity, CancellationToken cancellationToken)
    {
        try
        {
            await _context.Set<TEntity>().AddAsync(entity).ConfigureAwait(false);
            await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public async Task Update(TEntity entity, CancellationToken cancellationToken)
    {
        try
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
    public async Task Delete(long id, CancellationToken cancellationToken)
    {
        try
        {
            _context.Remove(id);
            await _context.SaveChangesAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}
