using Store.DAL.EF;
using Store.DAL.Models;
using Store.DAL.Repositories;

namespace Store.Infrastructure.Repositories.Factory
{
    internal sealed class RepositoryFactory : IRepositoryFactory
    {
        internal RepositoryFactory(StoreContext storeContext)
        {
            _storeContext = storeContext 
                ?? throw new ArgumentNullException(nameof(storeContext));
        }

        private readonly StoreContext _storeContext;

        public ICategoryRepository GetCategoryRepository()
        {
            return new CategoryRepository(_storeContext.Set<ICategory>());
        }

        public IProductRepository GetProductRepository()
        {
            return new ProductRepository(_storeContext.Set<IProduct>());
        }
    }
}