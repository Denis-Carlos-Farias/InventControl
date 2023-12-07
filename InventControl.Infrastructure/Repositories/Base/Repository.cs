
using InventControl.Domain.Entities;
using InventControl.Domain.Interfaces.Infrastructure;
using InventControl.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace InventControl.Infrastructure.Repositories.Base;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly InventControlContext _context;
    public Repository(InventControlContext context)
    {
        _context = context;
    }
    public Task<TEntity> Get(long id)
    {
        throw new NotImplementedException();
    }
    public async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> filter = null,
        Expression<Func<TEntity, object>> orderBy = null)
    {
        try
        {
            return await _context.Set<TEntity>().Where(filter).OrderBy(orderBy).ToListAsync();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public async Task Insert(TEntity entity)
    {
        try
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public async Task Update(TEntity entity)
    {
        try
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
    public async Task Delete(long id)
    {
        try
        {
            _context.Remove(id);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}
