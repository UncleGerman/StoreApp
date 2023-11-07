namespace Store.DAL.Entity
{
    public sealed class Order
    {
        public Order()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}