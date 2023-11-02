using Store.DAL.Entity.Base;

namespace Store.BLL.Entity
{
    public interface IProductDTO : IBaseEntity
    {
        public string Description { get; set; }

        public int Count { get; set; }

        public bool IsStock { get; set; }
    }
}