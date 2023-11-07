using AutoMapper;
using Store.DAL;
using Store.DAL.Entity;
using Store.DAL.Repositories;
using Store.BLL.Service.Interfaces;
using Store.BLL.Entity.Implementations;
using Store.BLL.Entity.Interfaces;
using Store.BLL.Service.ValidationService;

namespace Store.BLL.Service.Implementations
{
    internal sealed class CategoryService : ICategoryService
    {
        public CategoryService(
            IUnitOfWork unitOfWork,
            IMapper mapper, 
            IValueValidationService valueValidationService)
        {
            if (unitOfWork is null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }

            _categoryRepository = unitOfWork.GetCategoryRepository();

            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));

            _valueValidationService = valueValidationService 
                ?? throw new ArgumentNullException(nameof(valueValidationService));
        }

        private readonly ICategoryRepository _categoryRepository;

        private readonly IMapper _mapper;

        private readonly IValueValidationService _valueValidationService;

        public void Insert(ICategoryDTO categoryDTO)
        {
            _valueValidationService.CheckEntity(categoryDTO);

            var category = _mapper.Map<Category>(categoryDTO);
            _categoryRepository.Insert(category);
        }

        public void Update(ICategoryDTO categoryDTO)
        {
            _valueValidationService.CheckEntity(categoryDTO);

            var category = _mapper.Map<Category>(categoryDTO);
            _categoryRepository.Update(category);
        }

        public void Remove(int id)
        {
            _valueValidationService.CheckEntityId(id);

            var category = _categoryRepository.GetById(id);
            _valueValidationService.CheckEntity(category);

            _categoryRepository.Remove(category);
        }

        #region GetEntity

        public ICategoryDTO GetById(int id)
        {
            var categoryCount = _categoryRepository.GetAll().Count();
            _valueValidationService.CheckEntityId(id, categoryCount);

            var category = _categoryRepository.GetById(id);
            var categoryDTO = _mapper.Map<CategoryDTO>(category);

            return categoryDTO;
        }

        public IEnumerable<ICategoryDTO> GetAll()
        {
            var categories = _categoryRepository.GetAll();

            var categoriesDTO = _mapper.Map<IReadOnlyCollection<CategoryDTO>>(categories);

            return categoriesDTO;
        }

        #endregion
    }
}