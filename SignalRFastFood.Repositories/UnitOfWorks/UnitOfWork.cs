using SignalRFastFood.Entities.UnitOfWorks;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.UnitOfWorks;

public sealed class UnitOfWork : IUnitOfWork
{
    private readonly FastFoodDbContext _context;

    public UnitOfWork(FastFoodDbContext context)
    {
        _context = context;
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }
}