using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Store.BLL.Service;
using Store.DAL;
using Store.DAL.EF;
using Store.Infrastructure.AutoMapper;
using Store.Infrastructure.Repositories.Factory;

namespace Store.Infrastructure.Injections
{
    public static class ApplicationConfigServiceExtensions
    {
        public static IServiceCollection AddDbContext(
            this IServiceCollection services,
            string connection)
        {
            services.AddDbContext<DbContext, StoreContext>(options =>
            {
                options.UseSqlServer(connection);
            });

            return services;
        }

        public static IServiceCollection AddDAL(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryFactory, RepositoryFactory>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AppMappingProfile));

            return services;
        }

        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<ICategoryService, CategoryService>();

            return services;
        }
    }
}