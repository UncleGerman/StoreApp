using AutoMapper;
using Store.DAL;
using Store.DAL.Repositories;
using Store.BLL.Service.Interfaces;
using Store.BLL.Entity.Implementations;
using Store.BLL.Entity.Interfaces;
using Store.DAL.Entity;
using Store.BLL.Service.ValidationService;

namespace Store.BLL.Service.Implementations
{
    internal sealed class ProductService : IProductService
    {
        public ProductService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IValueValidationService valueValidationService)
        {
            if (unitOfWork is null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }

            _productRepository = unitOfWork.GetProductRepository();

            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));

            _valueValidationService = valueValidationService 
                ?? throw new ArgumentNullException(nameof(valueValidationService));
        }

        private readonly IProductRepository _productRepository;

        private readonly IMapper _mapper;

        private readonly IValueValidationService _valueValidationService;

        public void Insert(IProductDTO productDTO)
        {
            _valueValidationService.CheckEntity(productDTO);

            var product = _mapper.Map<Product>(productDTO);
            _productRepository.Insert(product);
        }

        public void Update(IProductDTO productDTO)
        {
            _valueValidationService.CheckEntity(productDTO);

            var product = _mapper.Map<Product>(productDTO);
            _productRepository.Update(product);
        }

        public void Remove(int id)
        {
            _valueValidationService.CheckEntityId(id);

            var product = _productRepository.GetById(id);
            _valueValidationService.CheckEntity(product);

            _productRepository.Remove(product);
        }

        #region GetEntity

        public IProductDTO GetById(int id)
        {
            var productsCount = _productRepository.GetCount();
            _valueValidationService.CheckEntityId(id, productsCount);

            var product = _productRepository.GetById(id);
            var productDTO = _mapper.Map<ProductDTO>(product);

            return productDTO;
        }

        public IReadOnlyCollection<IProductDTO> GetAll()
        {
            var products = _productRepository.GetAll();

            var productsDTO = _mapper.Map<IReadOnlyCollection<ProductDTO>>(products);

            return productsDTO;
        }

        #endregion
    }
}