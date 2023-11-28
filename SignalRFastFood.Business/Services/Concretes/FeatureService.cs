using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Entities.Services.Abstracts;
using SignalRFastFood.Entities.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class FeatureService : Service<Feature>, IFeatureService
{
    public FeatureService(IRepository<Feature> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}