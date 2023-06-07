using Microsoft.AspNetCore.Mvc;
using ProductApp.Dto.Responses;
using ProductApp.Mvc.Models;
using ProductApp.Services;
using System.Text.Json;

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
            //var productItem = new ProductItem { Product = selectedProduct, Quantity = 1 };
            //ProductCollection productCollection = getCourseCollectionFromSession();
            //productCollection.AddNewCourse(productItem);
            //saveToSession(productCollection);
            return Json(new {message = $"{selectedProduct.Name}-{selectedProduct.Id} Sepete Eklendi"});
        }


        private ProductCollection getCourseCollectionFromSession()
        {
            var serializedString = HttpContext.Session.GetString("sepetim");
            //ilk kez sepete kurs ekleniyorsa serializedstring boş olacak
            if (serializedString == null)//sepete ilk defa bir şey ekleniyor, sepet oluşmamış 
            {
                return new ProductCollection();// yeni bir instance oluştur
            }
            // içine girmezse demek ki önceden "sepetim" diye bir session oluşmuş ve içine bir şey atılmış
            var collection = JsonSerializer.Deserialize<ProductCollection>(serializedString);// geri serileştir
            return collection;
        }
        private void saveToSession(ProductCollection productCollection)
        {
            var serialized = JsonSerializer.Serialize<ProductCollection>(productCollection);
            if (!string.IsNullOrWhiteSpace(serialized)) //serialized değilse
            {
                HttpContext.Session.SetString("sepetim", serialized);
            }
        }
    }
}
