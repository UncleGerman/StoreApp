using Store.DAL.Models;
using Store.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Store.Infrastructure.Repositories
{
    internal sealed class ProductRepository : IProductRepository
    {
        internal ProductRepository(DbSet<IProduct> products)
        {
            _products = products
                ?? throw new ArgumentNullException(nameof(products));
        }

        private readonly DbSet<IProduct> _products;

        public void Insert(IProduct product)
        {
            _products.Add(product);
        }

        public void Remove(IProduct product)
        {
            _products.Remove(product);
        }

        public void Update(IProduct product)
        {
            _products.Update(product);
        }

        #region GetEntity

        public IProduct GetById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);

            return product;
        }

        public IEnumerable<IProduct> GetAll()
        {
            return _products.ToList();
        }

        #endregion
    }
}