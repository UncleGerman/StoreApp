using Store.DAL.Repositories;

namespace Store.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        public IProductRepository GetProductRepository();

        public ICategoryRepository GetCategoryRepository();

        public void Save();

        public void SaveAcync();
    }
}