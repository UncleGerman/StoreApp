using Store.BLL.Entity.Interfaces;

namespace Store.BLL.Service.Interfaces
{
    public interface IProductService
    {
        public void Insert(IProductDTO productDTO);

        public void Update(IProductDTO productDTO);

        public void Remove(int id);

        public IProductDTO GetById(int id);

        public IReadOnlyCollection<IProductDTO> GetAll();
    }
}