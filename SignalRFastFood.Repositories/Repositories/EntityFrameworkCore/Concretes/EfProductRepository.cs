﻿using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfProductRepository : EfBaseRepository<Product>, IProductRepository
{
    public EfProductRepository(FastFoodDbContext context) : base(context)
    {
    }
}