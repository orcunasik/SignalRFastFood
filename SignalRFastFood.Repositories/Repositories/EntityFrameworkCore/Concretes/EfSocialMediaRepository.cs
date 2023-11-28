﻿using SignalRFastFood.Entities.Models;
using SignalRFastFood.Entities.Repositories.Abstracts;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;

namespace SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;

public class EfSocialMediaRepository : EfBaseRepository<SocialMedia>, ISocialMediaRepository
{
    public EfSocialMediaRepository(FastFoodDbContext context) : base(context)
    {
    }
}