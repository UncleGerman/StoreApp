using Store.DAL.Entity;
using Store.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Store.Infrastructure.Repositories
{
    internal sealed class OrderRepository : IOrderRepository
    {
        public OrderRepository(DbSet<Order> orders)
        {
            _orders = orders
                ?? throw new ArgumentNullException(nameof(orders));
        }

        private readonly DbSet<Order> _orders;

        public void Insert(Order order)
        {
            _orders.Add(order);
        }

        public void Update(Order order)
        {
            _orders.Update(order);
        }

        public void Remove(Order order)
        {
            _orders.Remove(order);
        }

        #region GetEntity

        public Order? GetById(int id)
        {
            var product = _orders.FirstOrDefault(o => o.Id == id);

            return product;
        }

        public IEnumerable<Order> GetAll()
        {
            return _orders.ToList();
        }

        #endregion
    }
}
