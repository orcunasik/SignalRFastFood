using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfBookingRepository : EfBaseRepository<Booking>, IBookingRepository
{
    public EfBookingRepository(FastFoodDbContext context) : base(context)
    {
    }
}
