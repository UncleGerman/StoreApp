using Store.DAL.Entity;

namespace Store.DAL.Repositories
{
    internal interface IOrderRepository
    {
        public void Insert(Order order);

        public void Update(Order order);

        public void Remove(Order order);

        public Order? GetById(int id);

        public IEnumerable<Order> GetAll();
    }
}