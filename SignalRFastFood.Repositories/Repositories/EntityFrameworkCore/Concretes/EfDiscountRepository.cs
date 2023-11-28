using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfDiscountRepository : EfBaseRepository<Discount>, IDiscountRepository
{
    public EfDiscountRepository(FastFoodDbContext context) : base(context)
    {
    }
}