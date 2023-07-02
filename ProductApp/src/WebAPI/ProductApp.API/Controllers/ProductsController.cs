using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.API.Filters;
using ProductApp.Dto.Requests;
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
            if (product == null)
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
        public IActionResult GetProductByCategory(int categoryId)
        {
            var products = _productService.GetProductByCategory(categoryId);
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewProductRequest request)
        {
            if (ModelState.IsValid)//request'in kurallarına uydun mu, uyduysa
            {
                var lastProductId = await _productService.CreateProductAndReturnIdAsync(request);//int döndürmesi daha anlamlı olur kullanılan metodun
                return CreatedAtAction(nameof(GetProduct), routeValues: new { id = lastProductId }, null); //201 döndürür, yani yeni bir kaynak oluşturulduğunu bildirir.
                                                                                                           //evet bu yeni isteği kaydettim ve bunun detaylarına şu linkten ulaşabilirsin diyoruz
            }
            return BadRequest(ModelState);//request'in kurallarına uymadıysa direk exception yesin
        }
        [HttpPut("{id}")]//ıdempotent = hep aynı sonuc
        public async Task<IActionResult> Update(int id, UpdateProductRequest updateProductRequest)
        {
            var isExist = await _productService.ProductIsExists(id);
            if (isExist)//varsa güncelleyeceğiz
            {
                if (ModelState.IsValid)//kurallara uyuyor mu
                {
                    await _productService.UpdateProduct(updateProductRequest);
                    return Ok();//201 de dönebiliriz
                }
                return BadRequest(ModelState);
            }
            return NotFound();//yoksa 
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _productService.ProductIsExists(id))//böyle bir şey varsa
            {
                var product = await _productService.GetProductForDeleteAsync(id);
                await _productService.DeleteProduct(product);
                return Ok();
            }
            return NotFound();
        }

        [HttpGet("[action]")]
        [NotImplemented]
        public async Task<IActionResult> Bitmemis(int id)
        {
            throw new NotImplementedException(); 
        }
    }
}
