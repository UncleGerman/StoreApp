using Store.DAL.Entity.Base;

namespace Store.DAL.Entity
{
    public sealed class Category : BaseEntity
    {
        public Category()
        {
            Products = new List<Product>();
        }

        public IEnumerable<Product> Products { get; set; }
    }
}