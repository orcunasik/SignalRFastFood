using Microsoft.EntityFrameworkCore;
using SignalRFastFood.Core.Models;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfProductRepository : EfBaseRepository<Product>, IProductRepository
{
    public EfProductRepository(FastFoodDbContext context) : base(context)
    {
    }

    public async Task<IList<Product>> GetProductsWithCategoryAsync()
    {
        FastFoodDbContext context = new();
        IList<Product> products = await context.Products.Include(p => p.Category).ToListAsync();
        return products;
    }
}