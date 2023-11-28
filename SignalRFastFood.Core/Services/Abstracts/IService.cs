using System.Linq.Expressions;

namespace SignalRFastFood.Entities.Services.Abstracts;

public interface IService<T> where T : class
{
    Task AddAsync(T entity);
    Task AddRangeAsync(IList<T> entites);
    Task RemoveByIdAsync(int id);
    Task RemoveAsync(T entity);
    Task RemoveRangeAsync(IList<T> entities);
    Task UpdateAsync(T entity);

    Task<T> GetByIdAsync(int id);
    Task<IList<T>> GetAllAsync();
    IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
}