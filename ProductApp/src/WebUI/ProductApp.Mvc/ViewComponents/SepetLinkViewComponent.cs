using Microsoft.AspNetCore.Mvc;
using ProductApp.Mvc.Extensions;
using ProductApp.Mvc.Models;

namespace ProductApp.Mvc.ViewComponents
{
    public class SepetLinkViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            var courseCollection = HttpContext.Session.GetJson<ProductCollection>("sepetim");

            return View(courseCollection);
        }
    }
}
