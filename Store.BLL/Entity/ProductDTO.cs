using Store.BLL.Entity.Base;

namespace Store.BLL.Entity
{
    public sealed class ProductDTO : BaseEntityDTO, IProductDTO
    {
        public string Description { get; set; }

        public int Count { get; set; }

        public bool IsStock { get; set; }
    }
}