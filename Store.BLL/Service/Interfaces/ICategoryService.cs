using Store.BLL.Entity.Interfaces;

namespace Store.BLL.Service.Interfaces
{
    public interface ICategoryService
    {
        public void Insert(ICategoryDTO categoryDTO);

        public void Update(ICategoryDTO categoryDTO);

        public void Remove(int id);

        public ICategoryDTO GetById(int id);

        public IEnumerable<ICategoryDTO> GetAll();
    }
}