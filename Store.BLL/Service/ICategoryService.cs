using Store.BLL.Entity;

namespace Store.BLL.Service
{
    public interface ICategoryService
    {
        public void Insert(ICategoryDTO categoryDTO);

        public void Remove(ICategoryDTO categoryDTO);

        public void Update(ICategoryDTO categoryDTO);

        public ICategoryDTO GetById(int id);

        public IEnumerable<ICategoryDTO> GetAll();
    }
}