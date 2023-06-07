using Microsoft.AspNetCore.Mvc;
using ProductApp.Dto.Responses;
using ProductApp.Mvc.Models;
using ProductApp.Services;
using System.Text.Json;
using ProductApp.Mvc.Extensions;

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
            var productCollection = getCourseCollectionFromSession();
            return View(productCollection);
        }
        public IActionResult AddProduct(int id)
        {
            ProductDisplayResponse selectedProduct = _productService.GetProduct(id);
            var productItem = new ProductItem { Product = selectedProduct, Quantity = 1 };
            ProductCollection productCollection = getCourseCollectionFromSession();
            productCollection.AddNewCourse(productItem);
            saveToSession(productCollection);
            return Json(new {message = $"Ürün Sepete Eklendi"});
        }


        private ProductCollection getCourseCollectionFromSession()
        {
            return HttpContext.Session.GetJson<ProductCollection>("sepetim") ?? new ProductCollection();
        }
        private void saveToSession(ProductCollection productCollection)
        {
            HttpContext.Session.SetJson("sepetim", productCollection);
        }
    }
}
