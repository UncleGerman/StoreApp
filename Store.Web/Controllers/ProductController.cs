using Microsoft.AspNetCore.Mvc;
using Store.BLL.Entity;
using Store.BLL.Service;

namespace Store.Web.Controllers
{
    public sealed class ProductController : Controller
    {
        public ProductController(IProductService productService)
        {
            _productService = productService 
                ?? throw new ArgumentNullException(nameof(productService));
        }

        private readonly IProductService _productService;

        public void Insert(ProductDTO product)
        {
            _productService.Insert(product);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
