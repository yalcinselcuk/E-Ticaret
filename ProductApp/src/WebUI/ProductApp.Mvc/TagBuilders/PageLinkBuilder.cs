using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using ProductApp.Mvc.Models;

namespace ProductApp.Mvc.TagBuilders
{
    //bu div attribute olarak page-model'i almazsa çalışmaz diyoruz
    [HtmlTargetElement("div", Attributes = "page-model")]//bu sayfanın hedefleri element div. Yani div'in içinde oluşmasını istiyoruz kodların
    public class PageLinkBuilder : TagHelper
    {
        public string PageAction { get; set; } 
        public PaginationInfo PageModel { get; set; }

        IUrlHelperFactory urlHelperFactory;


        //View'in içinden buraya ulaşmak için;
        [ViewContext]//viewcontext olduğunu belirttik
        [HtmlAttributeNotBound]//bu html'de görünmesini istemediğimizden kullanma dedik
        public ViewContext ViewContext { get; set; }//bir şeyin adında Context varsa : kapsam, kavram anlamındadır

        public PageLinkBuilder(IUrlHelperFactory factory)
        {
            urlHelperFactory = factory;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //amacımız bunu oluşturmak;
            /*
             <div>
              <ul class="pagination justify-content-center">
                <li class="page-item active" aria-current="page">
                  <span class="page-link">1</span>
                </li>
                <li class="page-item"><a class="page-link" href="#">2</a></li>
                <li class="page-item"><a class="page-link" href="#">3</a></li>
              </ul>
            </div>
            //bu da bizim index.cshtml'de yazdığımız
             <div> 
              <ul class="pagination justify-content-center">
    
                @for (int i = 1; i <= ViewBag.TotalPage; i++)
                    {
                        <li class="page-item @(i == ViewBag.PageNo ? "active" : "")"><a asp-action="Index" asp-route-pageNo="@i" class="page-link">@i</a></li>
                    }
              </ul>
            </div>
             */

            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);//nereye gideceğini belirttik
            TagBuilder div = new TagBuilder("div");// div'i ürettik
            TagBuilder ul = new TagBuilder("ul");
            ul.AddCssClass("pagination justify-content-center");
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder li = new TagBuilder("li");
                li.AddCssClass("page-item");
                if (i == PageModel.CurrentPage) { li.AddCssClass(" active"); }

                TagBuilder a = new TagBuilder("a");
                a.AddCssClass("page-link");
                a.Attributes["href"] = urlHelper.Action(PageAction, new { pageNo = i });//homecontroller'a giden pageNo => burada da pageNo dönecek
                a.InnerHtml.Append(i.ToString());
                li.InnerHtml.AppendHtml(a);
                ul.InnerHtml.AppendHtml(li);
            }
            div.InnerHtml.AppendHtml(ul);
            output.Content.AppendHtml(div);
        }
    }
}
