using Store.DAL;
using Store.DAL.EntityFramework;
using Store.DAL.Repositories;
using Store.Infrastructure.Repositories.Factory;

namespace Store.Infrastructure
{
    internal sealed class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(
            StoreContext storeContext,
            IRepositoryFactory repositoryFactory)
        {
            _storeContext = storeContext
                ?? throw new ArgumentNullException(nameof(storeContext));

            _repositoryFactory = repositoryFactory 
                ?? throw new ArgumentNullException(nameof(repositoryFactory));
        }

        private readonly StoreContext _storeContext;

        private readonly IRepositoryFactory _repositoryFactory;

        private bool _disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (_disposed == true)
            {
                
            }
            else
            {
                if (disposing == true)
                {
                    _storeContext.Dispose();
                }
                else
                {
                    _disposed = true;
                }
            }
        }

        #region GetRepository

        public ICategoryRepository GetCategoryRepository()
        {
            return _repositoryFactory.GetCategoryRepository();
        }

        public IProductRepository GetProductRepository()
        {
            return _repositoryFactory.GetProductRepository();
        }

        public IOrderRepository GetOrderRepository()
        {
            return _repositoryFactory.GetOrderRepository();
        }

        #endregion

        #region Save

        public void Save()
        {
            _storeContext.SaveChanges();
        }

        public async void SaveAcync()
        {
            await _storeContext.SaveChangesAsync();
        }

        #endregion
    }
}
