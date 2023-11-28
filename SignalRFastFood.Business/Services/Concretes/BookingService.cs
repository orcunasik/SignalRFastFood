using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Core.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class BookingService : Service<Booking>, IBookingService
{
    public BookingService(IRepository<Booking> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}