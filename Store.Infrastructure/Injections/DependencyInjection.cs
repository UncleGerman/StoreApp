using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Store.DAL.EntityFramework;

namespace Store.Infrastructure.Injections
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDbContext(
            this IServiceCollection services,
            IConfiguration configure)
        {
            var connection = configure.GetConnectionString("DefaultConnection");

            services.AddDbContext<StoreContext>(options =>
            {
                options.UseSqlServer(connection);
            });

            return services;
        }
    }
}