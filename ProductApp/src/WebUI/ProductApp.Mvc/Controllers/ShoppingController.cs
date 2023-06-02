using Microsoft.AspNetCore.Mvc;
using ProductApp.Dto.Responses;
using ProductApp.Services;

namespace ProductApp.Mvc.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly IProductService _productService;
        public ShoppingController(IProductService productService)
        {
            _productService= productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddProduct(int id)
        {
            ProductDisplayResponse selectedProduct = _productService.GetProduct(id);
            return Json(new {message = $"{selectedProduct.Name}-{selectedProduct.Id} Sepete Eklendi"});
        }
    }
}
