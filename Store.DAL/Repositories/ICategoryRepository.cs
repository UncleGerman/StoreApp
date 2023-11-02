using Store.DAL.Models;

namespace Store.DAL.Repositories
{
    public interface ICategoryRepository
    {
        public void Insert(ICategory category);

        public void Remove(ICategory category);

        public void Update(ICategory category);

        public ICategory GetById(int id);

        public IEnumerable<ICategory> GetAll();
    }
}