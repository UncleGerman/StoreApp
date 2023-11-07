using Store.DAL.Entity;
using Store.DAL.Repositories;
using Store.DAL.EntityFramework;

namespace Store.Infrastructure.Repositories.Factory
{
    internal sealed class RepositoryFactory : IRepositoryFactory
    {
        public RepositoryFactory(StoreContext storeContext)
        {
            _storeContext = storeContext
                ?? throw new ArgumentNullException(nameof(storeContext));
        }

        private readonly StoreContext _storeContext;

        public ICategoryRepository GetCategoryRepository()
        {
            return new CategoryRepository(_storeContext.Set<Category>());
        }

        public IProductRepository GetProductRepository()
        {
            return new ProductRepository(_storeContext.Set<Product>());
        }

        public IOrderRepository GetOrderRepository()
        {
            return new OrderRepository(_storeContext.Set<Order>());
        }
    }
}