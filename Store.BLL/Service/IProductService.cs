using Store.BLL.Entity;

namespace Store.BLL.Service
{
    public interface IProductService
    {
        public void Insert(IProductDTO productDTO);

        public void Remove(IProductDTO productDTO);

        public void Update(IProductDTO productDTO);

        public IProductDTO GetById(int id);

        public IEnumerable<IProductDTO> GetAll();
    }
}