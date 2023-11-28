using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Core.UnitOfWorks;

namespace SignalRFastFood.Business.Services.Concretes;

public class ProductService : Service<Product>, IProductService
{
    public ProductService(IRepository<Product> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
    {
    }
}