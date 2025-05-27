using DomainDrivenDesignNet8.Domain.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DomainDrivenDesignNet8.Application;

//mediatr için di eklendi.
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfr =>
        {
            //mediatr için assembly eklendi.
            //domain katmanındaki bağlı events bulur.
            cfr.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly(), typeof(Entity).Assembly);
        });

        return services;
    }
}
