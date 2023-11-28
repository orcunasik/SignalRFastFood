using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Core.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class AboutService : Service<About>, IAboutService
{
    public AboutService(IRepository<About> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}