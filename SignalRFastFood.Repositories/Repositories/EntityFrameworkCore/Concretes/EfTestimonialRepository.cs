using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfTestimonialRepository : EfBaseRepository<Testimonial>, ITestimonialRepository
{
    public EfTestimonialRepository(FastFoodDbContext context) : base(context)
    {
    }
}
