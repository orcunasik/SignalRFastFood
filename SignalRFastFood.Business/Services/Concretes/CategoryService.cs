using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Entities.Services.Abstracts;
using SignalRFastFood.Entities.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class CategoryService : Service<Category>, ICategoryService
{
    public CategoryService(IRepository<Category> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}