using Store.DAL.Entity.Base;

namespace Store.DAL.Entity
{
    public interface IProduct : IBaseEntity
    {
        public string Description { get; set; }

        public int Count { get; set; }

        public bool IsStock { get; set; }
    }
}