using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Store.Infrastructure")]
namespace Store.BLL.Entity.Base
{
    public abstract class BaseEntityDTO : IBaseEntityDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = "New Product";
    }
}