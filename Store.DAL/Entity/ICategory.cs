using Store.DAL.Entity.Base;

namespace Store.DAL.Entity
{
    public interface ICategory : IBaseEntity
    {
        public IEnumerable<IProduct> Products { get; set; }
    }
}