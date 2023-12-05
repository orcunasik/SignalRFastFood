using SignalRFastFood.Core.Models;

namespace SignalRFastFood.Core.Services.Abstracts;

public interface IProductService : IService<Product>
{
    Task<IList<Product>> GetProductsWithCategoryAsync();
}