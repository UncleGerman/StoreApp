using Microsoft.AspNetCore.Mvc;
using Store.BLL.Service.Interfaces;
using Store.BLL.Entity.Interfaces;

namespace Store.Web.Controllers
{
    [ApiController]
    [Route("api/category")]
    public sealed class CategoryController : Controller
    {
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService 
                ?? throw new ArgumentNullException(nameof(categoryService));
        }

        private readonly ICategoryService _categoryService;

        [HttpPost]
        public IActionResult Insert(ICategoryDTO category)
        {
            _categoryService.Insert(category);

            return Ok(category);
        }

        [HttpPut]
        public void Update(ICategoryDTO category)
        {
            _categoryService.Update(category);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _categoryService.Remove(id);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }
            else
            {
                var category = _categoryService.GetById(id);

                return Ok(category);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<ICategoryDTO>> GetAll()
        {
            var categories = _categoryService.GetAll();

            if (categories.Any())
            {
                return Ok(categories);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}