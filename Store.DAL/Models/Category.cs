using Store.DAL.Models.Base;

namespace Store.DAL.Models
{
    public sealed class Category : BaseEntity, ICategory
    {
        public IEnumerable<IProduct> Products { get; set; }
    }
}