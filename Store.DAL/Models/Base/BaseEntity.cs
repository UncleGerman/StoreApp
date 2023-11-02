namespace Store.DAL.Models.Base
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}