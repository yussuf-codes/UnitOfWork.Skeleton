using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.IServices;
using Services.Repositories;
using Services.Repositories.IRepositories;

namespace Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IModel1Repository, Model1Repository>();
        services.AddScoped<IModel2Repository, Model2Repository>();
        services.AddScoped<IModel3Repository, Model3Repository>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
