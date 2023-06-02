using ProductApp.Dto.Responses;

namespace ProductApp.Mvc.Models
{
    public class PaginationProductViewModel
    {
        // her view bir modelle çalışacağından ve biz iki modeli bir view'de kullanmak istediğimizden
        // gidip iki modelden de birer tane instance oluştururuz 3.modelde ve bu modeli kullanırız
        public IEnumerable<ProductDisplayResponse> Products { get; set; }
        public PaginationInfo PaginationInfo { get; set; }
    }
}
