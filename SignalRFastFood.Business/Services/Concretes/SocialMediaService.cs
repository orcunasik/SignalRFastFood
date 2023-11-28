using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Core.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class SocialMediaService : Service<SocialMedia>, ISocialMediaService
{
    public SocialMediaService(IRepository<SocialMedia> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}