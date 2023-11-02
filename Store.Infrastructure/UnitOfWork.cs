using Store.DAL;
using Store.DAL.Repositories;
using Store.Infrastructure.Repositories.Factory;
using Microsoft.EntityFrameworkCore;

namespace Store.Infrastructure
{
    internal sealed class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(
            DbContext dbContext,
            IRepositoryFactory repositoryFactory)
        {
            _dbContext = dbContext 
                ?? throw new ArgumentNullException(nameof(dbContext));

            _repositoryFactory = repositoryFactory 
                ?? throw new ArgumentNullException(nameof(repositoryFactory));
        }

        private readonly DbContext _dbContext;

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
            _dbContext.SaveChanges();
        }

        public async void SaveAcync()
        {
            await _dbContext.SaveChangesAsync();
        }

        #endregion
    }
}
