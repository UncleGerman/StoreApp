using Store.DAL;
using Store.Infrastructure.Repositories.Factory;
using Microsoft.Extensions.DependencyInjection;

namespace Store.Infrastructure.Injections
{
    public static class InjectionDAL
    {
        public static IServiceCollection AddDAL(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryFactory, RepositoryFactory>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}