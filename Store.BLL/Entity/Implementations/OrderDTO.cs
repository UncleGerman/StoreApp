using Store.BLL.Entity.Interfaces;

namespace Store.BLL.Entity.Implementations
{
    internal sealed class OrderDTO : IOrderDTO
    {
        public int Id { get; set; }

        public IEnumerable<IProductDTO> Products { get; set; } = new List<IProductDTO>();
    }
}