
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
    public async Task<TEntity> GetAsync(long id, CancellationToken cancellationToken)
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
    public async Task<IEnumerable<TEntity>> GetAsync(CancellationToken cancellationToken, Expression<Func<TEntity, bool>> filter = null,
        Expression<Func<TEntity, object>> orderBy = null)
    {
        try
        {
            if (filter != null && orderBy != null) {
                return await _context.Set<TEntity>().AsNoTracking().Where(filter).OrderBy(orderBy).ToListAsync(cancellationToken);
            }
            else if (filter != null && orderBy == null) 
            {
                return await _context.Set<TEntity>().AsNoTracking().Where(filter).ToListAsync(cancellationToken);
            }
            else if (filter == null && orderBy != null)
            {
                return await _context.Set<TEntity>().AsNoTracking().OrderBy(orderBy).ToListAsync(cancellationToken);
            }
            else
            {
                return await _context.Set<TEntity>().AsNoTracking().ToListAsync(cancellationToken);
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public async Task InsertAsync(TEntity entity, CancellationToken cancellationToken)
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
    public async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken)
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
    public async Task DeleteAsync(long id, CancellationToken cancellationToken)
    {
        try
        {
            var obj = await GetAsync(id, cancellationToken).ConfigureAwait(false);
            _context.Remove(obj);
            await _context.SaveChangesAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}
