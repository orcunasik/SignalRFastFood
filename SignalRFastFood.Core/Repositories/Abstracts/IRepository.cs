using System.Linq.Expressions;

namespace SignalRFastFood.Core.Repositories.Abstracts;

public interface IRepository<T> where T : class
{
    Task AddAsync(T entity);
    Task AddRangeAsync(IList<T> entities);
    Task RemoveByIdAsync(int id);
    void Remove(T entity);
    void RemoveRange(IList<T> entities);
    void Update(T entity);

    IQueryable<T> GetAll();
    IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
    Task<T> GetByIdAsync(int id);
}