using Microsoft.AspNetCore.Mvc;
using Store.BLL.Service.Interfaces;
using Store.BLL.Entity.Interfaces;

namespace Store.Web.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public sealed class OrderController : Controller
    {
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService 
                ?? throw new ArgumentNullException(nameof(orderService));
        }

        private readonly IOrderService _orderService;

        [HttpPost]
        public void Insert(IOrderDTO order)
        {
            _orderService.Insert(order);
        }

        [HttpPut]
        public void Update(IOrderDTO order)
        {
            _orderService.Update(order);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _orderService.Remove(id);
        }

        [HttpGet("{id}")]

        public IOrderDTO Get(int id)
        {
            return _orderService.GetById(id);
        }

        [HttpGet]
        public IEnumerable<IOrderDTO> GetAll()
        {
            return _orderService.GetAll();
        }
    }
}