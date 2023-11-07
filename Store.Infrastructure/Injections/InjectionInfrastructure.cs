using Microsoft.Extensions.DependencyInjection;
using Store.Infrastructure.AutoMapper;

namespace Store.Infrastructure.Injections
{
    public static class InjectionInfrastructure
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AppMappingProfile));

            return services;
        }
    }
}