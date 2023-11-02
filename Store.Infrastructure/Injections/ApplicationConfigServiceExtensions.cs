using Microsoft.Extensions.DependencyInjection;
using Store.BLL.Service;
using Store.DAL;
using Store.DAL.EF;
using Store.DAL.Repositories;
using Store.Infrastructure.Repositories;

namespace Store.Infrastructure.Injections
{
    public static class ApplicationConfigServiceExtensions
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services)
        {
            services.AddDbContext<StoreContext>();

            return services;
        }

        public static IServiceCollection AddDAL(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}