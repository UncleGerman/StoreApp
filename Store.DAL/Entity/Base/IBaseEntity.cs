namespace Store.DAL.Entity.Base
{
    public interface IBaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}