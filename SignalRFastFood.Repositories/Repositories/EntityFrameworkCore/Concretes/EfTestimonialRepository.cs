using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfTestimonialRepository : EfBaseRepository<Testimonial>, ITestimonialRepository
{
    public EfTestimonialRepository(FastFoodDbContext context) : base(context)
    {
    }
}
