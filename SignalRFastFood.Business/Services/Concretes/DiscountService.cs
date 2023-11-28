using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Entities.Services.Abstracts;
using SignalRFastFood.Entities.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class DiscountService : Service<Discount>, IDiscountService
{
    public DiscountService(IRepository<Discount> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}