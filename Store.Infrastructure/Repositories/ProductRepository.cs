using Store.DAL.Entity;
using Store.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Store.Infrastructure.Repositories
{
    internal sealed class ProductRepository : IProductRepository
    {
        public ProductRepository(DbSet<Product> products)
        {
            _products = products
                ?? throw new ArgumentNullException(nameof(products));
        }

        private readonly DbSet<Product> _products;

        public void Insert(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            _products.Update(product);
        }

        public void Remove(Product product)
        {
            _products.Remove(product);
        }

        #region GetEntity

        public Product? GetById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);

            return product;
        }

        public int GetCount()
        {
            return _products.Count();
        }

        public IReadOnlyCollection<Product> GetAll()
        {
            return _products.ToList();
        }

        #endregion
    }
}