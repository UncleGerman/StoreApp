namespace Store.DAL.Models.Base
{
    public interface IBaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}