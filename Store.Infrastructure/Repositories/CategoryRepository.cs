using Store.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Store.DAL.Entity;

namespace Store.Infrastructure.Repositories
{
    public sealed class CategoryRepository : ICategoryRepository
    {
        public CategoryRepository(DbSet<Category> categories)
        {
            _categories = categories
                ?? throw new ArgumentNullException(nameof(categories));
        }

        private readonly DbSet<Category> _categories;

        public void Insert(Category category)
        {
            _categories.Add(category);
        }

        public void Remove(Category category)
        {
            _categories.Remove(category);
        }

        public void Update(Category category)
        {
            _categories.Update(category);
        }

        #region GetEntity

        public Category GetById(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);

            return category;
        }

        public IEnumerable<Category> GetAll()
        {
            return _categories.ToList();
        }

        #endregion
    }
}