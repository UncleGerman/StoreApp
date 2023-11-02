using Store.DAL;
using Store.DAL.Repositories;
using Store.Infrastructure.Repositories.Factory;
using Microsoft.EntityFrameworkCore;
using Store.DAL.EF;

namespace Store.Infrastructure
{
    public sealed class UnitOfWork : IUnitOfWork
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

        public void Dispose()
        {
            throw new NotImplementedException();
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
