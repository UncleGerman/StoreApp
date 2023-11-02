using Store.DAL.Models.Base;

namespace Store.DAL.Models
{
    public interface IProduct : IBaseEntity
    {
        public string Description { get; set; }

        public int Count { get; set; }

        public bool IsStock { get; set; }
    }
}