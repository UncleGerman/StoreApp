using Microsoft.AspNetCore.Mvc;
using Store.BLL.Entity.Interfaces;
using Store.BLL.Service.Interfaces;

namespace Store.Web.Controllers
{
    [ApiController]
    [Route("api/products")]
    public sealed class ProductController : Controller
    {
        public ProductController(IProductService productService)
        {
            _productService = productService 
                ?? throw new ArgumentNullException(nameof(productService));
        }

        private readonly IProductService _productService;

        public IActionResult Index()
        {
            return View("products");
        }

        [HttpPost]
        public void Insert(IProductDTO product)
        {
            _productService.Insert(product);
        }

        [HttpPut]
        public void Update(IProductDTO product)
        {
            _productService.Update(product);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.Remove(id);
        }

        [HttpGet("{id}")]

        public IProductDTO Get(int id)
        {
            return _productService.GetById(id);
        }

        [HttpGet]
        public IEnumerable<IProductDTO> GetAll()
        {
            return _productService.GetAll();
        }
    }
}