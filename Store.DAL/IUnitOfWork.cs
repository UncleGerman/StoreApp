using Store.DAL.Repositories;

namespace Store.DAL
{
    internal interface IUnitOfWork : IDisposable
    {
        public IProductRepository GetProductRepository();

        public ICategoryRepository GetCategoryRepository();

        public IOrderRepository GetOrderRepository();

        public void Save();

        public void SaveAcync();
    }
}