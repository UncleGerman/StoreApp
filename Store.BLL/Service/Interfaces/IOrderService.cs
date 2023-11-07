using Store.BLL.Entity.Interfaces;

namespace Store.BLL.Service.Interfaces
{
    public interface IOrderService
    {
        public void Insert(IOrderDTO orderDTO);

        public void Update(IOrderDTO orderDTO);

        public void Remove(int id);

        public IOrderDTO GetById(int id);

        public IEnumerable<IOrderDTO> GetAll();
    }
}