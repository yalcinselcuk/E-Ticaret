using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductApp.Dto.Requests;
using ProductApp.Services;
using System.Data;

namespace ProductApp.Mvc.Controllers
{
    [Authorize(Roles = "Admin, Editor")]
    public class ProductsController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = productService.GetProductsResponse();
            return View(products);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = getCategoriesForSelectList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateNewProductRequest createNewProductRequest)
        {
            if (ModelState.IsValid)
            {
                await productService.CreateProductAsync(createNewProductRequest);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = getCategoriesForSelectList();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Categories = getCategoriesForSelectList();
            var product = await productService.GetProductForUpdateAsync(id);
            
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, UpdateProductRequest updateProductRequest)
        {
            if (await productService.ProductIsExists(id))
            {
                if (ModelState.IsValid)
                {
                    await productService.UpdateProduct(updateProductRequest);
                    return RedirectToAction(nameof(Index));
                }
                ViewBag.Categories = getCategoriesForSelectList();
                return View();
            }
            return NotFound();
        }

        private IEnumerable<SelectListItem> getCategoriesForSelectList()
        {
            var categories = categoryService.GetCategoryDisplayResponses().Select(c => new SelectListItem { Text = c.CategoryName, Value = c.Id.ToString() }).ToList();
            categories.Insert(0, new SelectListItem { Text = "Seçiniz", Value = string.Empty });
            return categories;
        }
    }
}
