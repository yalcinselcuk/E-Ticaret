using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ProductApp.API.Filters
{
    public class NotImplementedAttribute : ExceptionFilterAttribute
    {
        //ExceptionFilterAttribute miras alındığında ezilmesi gereken birkaç metod vardır.tabi ki hepsi ezilebilir ama biz bir iki tanesini ezicez

        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is NotImplementedException)
            {
                string message = $"Request gönderdiğiniz adreste herhangi bir geliştirme yapılmamıştır. action adı : {context.ActionDescriptor.DisplayName} ";

                context.Result = new BadRequestObjectResult(new {errormessage = message});

            }
        }
    }
}
