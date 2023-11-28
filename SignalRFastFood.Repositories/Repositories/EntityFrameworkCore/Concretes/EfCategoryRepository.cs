using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfCategoryRepository : EfBaseRepository<Category>, ICategoryRepository
{
    public EfCategoryRepository(FastFoodDbContext context) : base(context)
    {
    }
}