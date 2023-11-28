using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Core.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class CategoryService : Service<Category>, ICategoryService
{
    public CategoryService(IRepository<Category> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}