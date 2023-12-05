using SignalRFastFood.Business.Mapping;
using SignalRFastFood.Business.Services.Concretes;
using SignalRFastFood.Core.Repositories.Abstracts;
using SignalRFastFood.Core.Services.Abstracts;
using SignalRFastFood.Core.UnitOfWorks;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Concretes;
using SignalRFastFood.Repositories.Repositories.EntityFrameworkCore.Context;
using SignalRFastFood.Repositories.UnitOfWorks;
using System.Reflection;

namespace SignalRFastFood.Api.Modules;

public static class RepoServiceModule
{
    public static IServiceCollection AddRepositoriesAndServices(this IServiceCollection services)
    {
        services.AddDbContext<FastFoodDbContext>();
        services.AddScoped(typeof(IRepository<>), typeof(EfBaseRepository<>));
        services.AddScoped(typeof(IService<>), typeof(Service<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddAutoMapper(typeof(CategoryMapping));

        Assembly apiAssembly = Assembly.GetExecutingAssembly();
        Assembly repoAssembly = Assembly.GetAssembly(typeof(FastFoodDbContext));
        Assembly serviceAssembly = Assembly.GetAssembly(typeof(AboutService));

        services.Scan(scan => scan
            .FromAssemblies(apiAssembly, repoAssembly, serviceAssembly)
            .AddClasses(classes => classes.Where(type => type.Name.EndsWith("Repository")))
            .AsImplementedInterfaces()
            .WithScopedLifetime()
        );

        services.Scan(scan => scan
            .FromAssemblies(apiAssembly, repoAssembly, serviceAssembly)
            .AddClasses(classes => classes.Where(type => type.Name.EndsWith("Service")))
            .AsImplementedInterfaces()
            .WithScopedLifetime()
        );
        return services;
    }
}