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
    }
}
