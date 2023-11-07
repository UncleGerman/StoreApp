using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Store.DAL.Entity;

[assembly: InternalsVisibleTo("Store.Infrastructure")]
[assembly: InternalsVisibleTo("Store.BLL")]
namespace Store.DAL.EntityFramework
{
    internal sealed class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Tom", Description = "", Price = 100 },
                new Product { Id = 2, Name = "Bob", Description = "", Price = 100 },
                new Product { Id = 3, Name = "Sam", Description = "", Price = 100 }
            );
        }
    }
}