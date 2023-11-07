using Store.DAL.Entity;

namespace Store.DAL.Repositories
{
    internal interface IProductRepository
    {
        public void Insert(Product product);

        public void Update(Product product);

        public void Remove(Product product);

        public Product? GetById(int id);

        public int GetCount();

        public IReadOnlyCollection<Product> GetAll();
    }
}