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
    internal sealed class OrderService : IOrderService
    {
        public OrderService(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IValueValidationService valueValidationService)
        {
            if (unitOfWork is null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }

            _orderRepository = unitOfWork.GetOrderRepository();

            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));

            _valueValidationService = valueValidationService 
                ?? throw new ArgumentNullException(nameof(valueValidationService));
        }

        private readonly IOrderRepository _orderRepository;

        private readonly IMapper _mapper;

        private readonly IValueValidationService _valueValidationService;

        public void Insert(IOrderDTO orderDTO)
        {
            _valueValidationService.CheckEntity(orderDTO);

            var order = _mapper.Map<Order>(orderDTO);
            _orderRepository.Insert(order);
        }

        public void Update(IOrderDTO orderDTO)
        {
            _valueValidationService.CheckEntity(orderDTO);

            var order = _mapper.Map<Order>(orderDTO);
            _orderRepository.Update(order);
        }

        public void Remove(int id)
        {
            _valueValidationService.CheckEntityId(id);

            var order = _orderRepository.GetById(id);
            _valueValidationService.CheckEntity(order);

            _orderRepository.Remove(order);
        }

        #region GetEntity

        public IOrderDTO GetById(int id)
        {
            var ordersCount = _orderRepository.GetAll().Count();
            _valueValidationService.CheckEntityId(id, ordersCount);

            var order = _orderRepository.GetById(id);
            var categoryDTO = _mapper.Map<OrderDTO>(order);

            return categoryDTO;
        }

        public IEnumerable<IOrderDTO> GetAll()
        {
            var orders = _orderRepository.GetAll();

            var ordersDTO = _mapper.Map<IReadOnlyCollection<OrderDTO>>(orders);

            return ordersDTO;
        }

        #endregion
    }
}