using Microsoft.AspNetCore.Mvc;
using WarehouseManagement.Application.Interfaces;

namespace WarehouseManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {

        private readonly IProductService _productService;

        private ProductController( IProductService productService )
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CreateProduct( [FromBody] CreateProductDto createProductDto)
        {
            var productDto = _productService.CreateProduct(createProductDto);
            return Ok(productDto);
        }
    }
}
