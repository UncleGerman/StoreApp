using Store.BLL.Service.Interfaces;
using Store.BLL.Service.Implementations;
using Microsoft.Extensions.DependencyInjection;
using Store.BLL.Service.ValidationService;

namespace Store.Infrastructure.Injections
{
    public static class InjectionBLL
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddScoped<IValueValidationService, ValueValidationService>();

            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<ICategoryService, CategoryService>();

            services.AddScoped<IOrderService, OrderService>();

            return services;
        }
    }
}