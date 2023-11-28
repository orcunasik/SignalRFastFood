using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Core.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class FeatureService : Service<Feature>, IFeatureService
{
    public FeatureService(IRepository<Feature> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}