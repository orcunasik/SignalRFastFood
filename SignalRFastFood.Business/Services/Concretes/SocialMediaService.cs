using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Entities.Services.Abstracts;
using SignalRFastFood.Entities.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class SocialMediaService : Service<SocialMedia>, ISocialMediaService
{
    public SocialMediaService(IRepository<SocialMedia> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}