using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfAboutRepository : EfBaseRepository<About>, IAboutRepository
{
    public EfAboutRepository(FastFoodDbContext context) : base(context)
    {
    }
}