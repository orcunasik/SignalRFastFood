using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Entities.Services.Abstracts;
using SignalRFastFood.Entities.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class TestimonialService : Service<Testimonial>, ITestimonialService
{
    public TestimonialService(IRepository<Testimonial> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}