using Store.DAL.Entity;

namespace Store.DAL.Repositories
{
    public interface ICategoryRepository
    {
        public void Insert(Category category);

        public void Remove(Category category);

        public void Update(Category category);

        public Category GetById(int id);

        public IEnumerable<Category> GetAll();
    }
}