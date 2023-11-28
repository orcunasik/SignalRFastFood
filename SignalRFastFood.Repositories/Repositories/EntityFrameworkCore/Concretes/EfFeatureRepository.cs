using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfFeatureRepository : EfBaseRepository<Feature>, IFeatureRepository
{
    public EfFeatureRepository(FastFoodDbContext context) : base(context)
    {
    }
}