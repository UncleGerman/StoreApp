using Store.DAL.Models;
using Store.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Store.Infrastructure.Repositories
{
    internal sealed class CategoryRepository : ICategoryRepository
    {
        internal CategoryRepository(DbSet<ICategory> categories)
        {
            _categories = categories
                ?? throw new ArgumentNullException(nameof(categories));
        }

        private readonly DbSet<ICategory> _categories;

        public void Insert(ICategory category)
        {
            _categories.Add(category);
        }

        public void Remove(ICategory category)
        {
            _categories.Remove(category);
        }

        public void Update(ICategory category)
        {
            _categories.Update(category);
        }

        #region GetEntity

        public ICategory GetById(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);

            return category;
        }

        public IEnumerable<ICategory> GetAll()
        {
            return _categories.ToList();
        }

        #endregion
    }
}