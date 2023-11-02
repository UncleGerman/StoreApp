using Store.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Store.DAL.Entity;

namespace Store.Infrastructure.Repositories
{
    public sealed class ProductRepository : IProductRepository
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

        public void Remove(Product product)
        {
            _products.Remove(product);
        }

        public void Update(Product product)
        {
            _products.Update(product);
        }

        #region GetEntity

        public Product GetById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);

            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            return _products.ToList();
        }

        #endregion
    }
}