using Microsoft.AspNetCore.Mvc;
using ProductApp.Mvc.Models;
using ProductApp.Services;
using System.Diagnostics;

namespace ProductApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;
        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            this.productService = productService;   
        }

        public IActionResult Index(int pageNo = 1)
        {
            var products = productService.GetProductsResponse();
            /*
                1.sayfa : 0 eleman atla, 8 eleman al
                2.sayfa : 8 eleman atla, 8 eleman al 
                3.sayfa = 16 eleman atla, 8 eleman al
             */

            /*
             Ürünlerin toplam sayfa sayısı için gerekli bilgiler ;
                -sayfada kaç ürün olacak
                -toplam kaç ürün var
             */

            var productPerPage = 8;
            var productCount = products.Count();
            var totalPage = Math.Ceiling((decimal)productCount / productPerPage);//yukarıya tamamladık 105 yerine 106 olursa, her sayfaya 5 tane olursa diye eksik sayfa olmasın
            ViewBag.TotalPage = totalPage;

            var paginatedProducts = products.OrderBy(c => c.Id)
                                          .Skip((pageNo - 1) * productPerPage)
                                          .Take(productPerPage)
                                          .ToList();

            return View(paginatedProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}