using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Core.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class TestimonialService : Service<Testimonial>, ITestimonialService
{
    public TestimonialService(IRepository<Testimonial> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}