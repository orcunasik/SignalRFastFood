using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfDiscountRepository : EfBaseRepository<Discount>, IDiscountRepository
{
    public EfDiscountRepository(FastFoodDbContext context) : base(context)
    {
    }
}