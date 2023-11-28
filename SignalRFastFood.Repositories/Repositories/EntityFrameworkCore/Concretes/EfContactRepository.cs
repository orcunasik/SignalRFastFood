using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfContactRepository : EfBaseRepository<Contact>, IContactRepository
{
    public EfContactRepository(FastFoodDbContext context) : base(context)
    {
    }
}