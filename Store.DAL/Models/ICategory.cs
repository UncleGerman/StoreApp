using Store.DAL.Models.Base;

namespace Store.DAL.Models
{
    public interface ICategory : IBaseEntity
    {
        public IEnumerable<IProduct> Products { get; set; }
    }
}