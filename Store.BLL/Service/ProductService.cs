using AutoMapper;
using Store.BLL.Entity;
using Store.DAL;
using Store.DAL.Entity;
using Store.DAL.Repositories;

namespace Store.BLL.Service
{
    public sealed class ProductService : IProductService
    {
        public ProductService(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            if (unitOfWork is null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }

            _productRepository = unitOfWork.GetProductRepository();

            _mapper = mapper 
                ?? throw new ArgumentNullException(nameof(mapper));
        }

        private readonly IProductRepository _productRepository;

        private readonly IMapper _mapper;

        public void Insert(IProductDTO productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);
            _productRepository.Insert(product);
        }

        public void Remove(IProductDTO productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);
            _productRepository.Remove(product);
        }

        public void Update(IProductDTO productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);
            _productRepository.Update(product);
        }

        #region GetEntity

        public IEnumerable<IProductDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public IProductDTO GetById(int id)
        {
            var product = _productRepository.GetById(id);
            var productDTO = _mapper.Map<ProductDTO>(product);

            return productDTO;
        }

        #endregion
    }
}
