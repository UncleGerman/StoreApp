using Store.DAL.Entity.Base;

namespace Store.DAL.Entity
{
    public sealed class Product : BaseEntity
    {
        public Product()
        {
            Orders = new List<Order>();
        }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }

        public bool IsStock { get; set; }

        public Category? Category { get; set; }

        public int? CategoryId { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}