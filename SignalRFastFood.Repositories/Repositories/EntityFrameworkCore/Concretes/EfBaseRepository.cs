using Microsoft.EntityFrameworkCore;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;
using System.Linq.Expressions;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfBaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly FastFoodDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public EfBaseRepository(FastFoodDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    public async Task AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public async Task AddRangeAsync(IList<TEntity> entities)
    {
        await _dbSet.AddRangeAsync(entities);
    }

    public IQueryable<TEntity> GetAll()
    {
        return _dbSet.AsNoTracking().AsQueryable();
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> expression)
    {
        return _dbSet.Where(expression);
    }

    public void Remove(TEntity entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task RemoveByIdAsync(int id)
    {
        TEntity entity = await _dbSet.FindAsync(id);
        Remove(entity);
    }

    public void RemoveRange(IList<TEntity> entities)
    {
        _dbSet.RemoveRange(entities);
    }

    public void Update(TEntity entity)
    {
        _dbSet.Update(entity);
    }
}