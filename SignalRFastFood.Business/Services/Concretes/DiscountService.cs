using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Core.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class DiscountService : Service<Discount>, IDiscountService
{
    public DiscountService(IRepository<Discount> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}