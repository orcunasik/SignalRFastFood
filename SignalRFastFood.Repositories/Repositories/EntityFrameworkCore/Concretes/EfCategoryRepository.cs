using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfCategoryRepository : EfBaseRepository<Category>, ICategoryRepository
{
    public EfCategoryRepository(FastFoodDbContext context) : base(context)
    {
    }
}