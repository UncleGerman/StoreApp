using Store.DAL.Repositories;

namespace Store.Infrastructure.Repositories.Factory
{
    internal interface IRepositoryFactory
    {
        public IProductRepository GetProductRepository();

        public ICategoryRepository GetCategoryRepository();

        public IOrderRepository GetOrderRepository();
    }
}