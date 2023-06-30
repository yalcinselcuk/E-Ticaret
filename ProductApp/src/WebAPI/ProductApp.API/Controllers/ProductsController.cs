using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Services;

namespace ProductApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // Public API : Rest olmalı (Representational -Temsili- State Transfer)

        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;   
        }

        [HttpGet]
        public IActionResult GetProducts() 
        {
            var products = _productService.GetProductsResponse();
            return Ok(products);
        }

        [HttpGet("{id:int}")]//iki tane aynı get metodu çakışacağından diğerini belirtmemiz, ayırt etmemiz gerekiyor
        public IActionResult GetProduct(int id)
        {
            var product = _productService.GetProduct(id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet("[action]")]//action dediğimizde artık metod adına göre cagirir
        public async Task<IActionResult> SearchProductByName(string name)
        {
            var products = await _productService.SearchByName(name);
            return Ok(products);
        }
        //controller'da iki tane default httpget olmaz 
        [HttpGet("[action]")]
        public  IActionResult GetProductByCategory(int categoryId)
        {
            var products =  _productService.GetProductByCategory(categoryId);
            return Ok(products);
        }
    }
}
