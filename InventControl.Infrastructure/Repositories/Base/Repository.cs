
using InventControl.Domain.Entities;
using InventControl.Domain.Interfaces.Infrastructure;
using InventControl.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace InventControl.Infrastructure.Repositories.Base;

public class Repository<TEntity>(InventControlContext context) : IRepository<TEntity> where TEntity : EntityBase
{
    public async Task<TEntity> GetAsync(long id, CancellationToken cancellationToken)
    {
        try
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await context.Set<TEntity>()
                .AsNoTracking()
                .Where(p => p.Id == id)
                .SingleOrDefaultAsync(cancellationToken);
#pragma warning restore CS8603 // Possible null reference return.
        }
        catch (Exception)
        {
            throw;
        }

    }
    public async Task<IEnumerable<TEntity>> GetAsync(CancellationToken cancellationToken, Expression<Func<TEntity, bool>>? filter = null,
        Expression<Func<TEntity, object>>? orderBy = null)
    {
        try
        {
            if (filter != null && orderBy != null) {
                return await context.Set<TEntity>().AsNoTracking().Where(filter).OrderBy(orderBy).ToListAsync(cancellationToken);
            }
            else if (filter != null && orderBy == null) 
            {
                return await context.Set<TEntity>().AsNoTracking().Where(filter).ToListAsync(cancellationToken);
            }
            else if (filter == null && orderBy != null)
            {
                return await context.Set<TEntity>().AsNoTracking().OrderBy(orderBy).ToListAsync(cancellationToken);
            }
            else
            {
                return await context.Set<TEntity>().AsNoTracking().ToListAsync(cancellationToken);
            }

        }
        catch (Exception)
        {
            throw;
        }
    }
    public async Task InsertAsync(TEntity entity, CancellationToken cancellationToken)
    {
        try
        {
            await context.Set<TEntity>().AddAsync(entity).ConfigureAwait(false);
            await context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken)
    {
        try
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync(cancellationToken);
        }
        catch (Exception)
        {
            throw;
        }

    }
    public async Task DeleteAsync(long id, CancellationToken cancellationToken)
    {
        try
        {
            var obj = await GetAsync(id, cancellationToken).ConfigureAwait(false);
            context.Remove(obj);
            await context.SaveChangesAsync(cancellationToken);
        }
        catch (Exception)
        {
            throw;
        }
    }

}
