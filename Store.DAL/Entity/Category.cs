using Store.DAL.Entity.Base;

namespace Store.DAL.Entity
{
    public sealed class Category : BaseEntity, ICategory
    {
        public IEnumerable<IProduct> Products { get; set; }
    }
}