using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfFeatureRepository : EfBaseRepository<Feature>, IFeatureRepository
{
    public EfFeatureRepository(FastFoodDbContext context) : base(context)
    {
    }
}