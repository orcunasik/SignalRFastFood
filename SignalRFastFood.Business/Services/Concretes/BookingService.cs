using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Entities.Services.Abstracts;
using SignalRFastFood.Entities.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class BookingService : Service<Booking>, IBookingService
{
    public BookingService(IRepository<Booking> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}