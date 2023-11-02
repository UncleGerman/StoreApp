using AutoMapper;
using Store.BLL.Entity;
using Store.DAL;
using Store.DAL.Repositories;
using Store.DAL.Entity;

namespace Store.BLL.Service
{
    public sealed class CategoryService : ICategoryService
    {
        public CategoryService(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            if (unitOfWork is null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }

            _categoryRepository = unitOfWork.GetCategoryRepository();

            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));
        }

        private readonly ICategoryRepository _categoryRepository;

        private readonly IMapper _mapper;

        public void Insert(ICategoryDTO categoryDTO)
        {
            var category = _mapper.Map<Category>(categoryDTO);
            _categoryRepository.Insert(category);
        }

        public void Remove(ICategoryDTO categoryDTO)
        {
            var category = _mapper.Map<Category>(categoryDTO);
            _categoryRepository.Remove(category);
        }

        public void Update(ICategoryDTO categoryDTO)
        {
            var category = _mapper.Map<Category>(categoryDTO);
            _categoryRepository.Update(category);
        }

        #region GetEntity

        public ICategoryDTO GetById(int id)
        {
            var category = _categoryRepository.GetById(id);
            var categoryDTO = _mapper.Map<CategoryDTO>(category);

            return categoryDTO;
        }

        public IEnumerable<ICategoryDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
