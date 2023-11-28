using Microsoft.EntityFrameworkCore;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Core.UnitOfWorks;
using System.Linq.Expressions;

namespace SignalRFastFood.Business.Services.Concretes;

public class Service<T> : IService<T> where T : class
{
    private readonly IRepository<T> _repository;
    private readonly IUnitOfWork _unitOfWork;

    public Service(IRepository<T> repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task AddAsync(T entity)
    {
        await _repository.AddAsync(entity);
        await _unitOfWork.CommitAsync();
    }

    public async Task AddRangeAsync(IList<T> entites)
    {
        await _repository.AddRangeAsync(entites);
        await _unitOfWork.CommitAsync();
    }

    public async Task<IList<T>> GetAllAsync()
    {
        return await _repository.GetAll().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
    {
        return _repository.GetWhere(expression);
    }

    public async Task RemoveAsync(T entity)
    {
        _repository.Remove(entity);
        await _unitOfWork.CommitAsync();
    }

    public async Task RemoveByIdAsync(int id)
    {
        await _repository.RemoveByIdAsync(id);
        await _unitOfWork.CommitAsync();
    }

    public async Task RemoveRangeAsync(IList<T> entities)
    {
        _repository.RemoveRange(entities);
        await _unitOfWork.CommitAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _repository.Update(entity);
        await _unitOfWork.CommitAsync();
    }
}