using Store.DAL.Entity.Base;

namespace Store.DAL.Entity
{
    public sealed class Product : BaseEntity, IProduct
    {
        public string Description { get; set; }

        public int Count { get; set; }

        public bool IsStock { get; set; }
    }
}