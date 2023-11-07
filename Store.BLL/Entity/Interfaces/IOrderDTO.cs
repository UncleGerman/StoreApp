namespace Store.BLL.Entity.Interfaces
{
    public interface IOrderDTO
    {
        public int Id { get; set; }

        public IEnumerable<IProductDTO> Products { get; set; }
    }
}