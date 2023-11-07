using Store.BLL.Entity.Base;
using Store.BLL.Entity.Interfaces;

namespace Store.BLL.Entity.Implementations
{
    internal sealed class ProductDTO : BaseEntityDTO, IProductDTO
    {
        public string? Description { get; set; }

        public int Count { get; set; }

        public bool IsStock { get; set; }
    }
}