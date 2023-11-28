using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Entities.Services.Abstracts;
using SignalRFastFood.Entities.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class AboutService : Service<About>, IAboutService
{
    public AboutService(IRepository<About> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}