using Store.DAL.Entity;

namespace Store.DAL.Repositories
{
    public interface IProductRepository
    {
        public void Insert(Product product);

        public void Remove(Product product);

        public void Update(Product product);

        public Product GetById(int id);

        public IEnumerable<Product> GetAll();
    }
}