using Store.DAL.Models;

namespace Store.DAL.Repositories
{
    public interface IProductRepository
    {
        public void Insert(IProduct product);

        public void Remove(IProduct product);

        public void Update(IProduct product);

        public IProduct GetById(int id);

        public IEnumerable<IProduct> GetAll();
    }
}