using Store.DAL.Repositories;

namespace Store.Infrastructure.Repositories.Factory
{
    public interface IRepositoryFactory
    {
        public IProductRepository GetProductRepository();

        public ICategoryRepository GetCategoryRepository();
    }
}