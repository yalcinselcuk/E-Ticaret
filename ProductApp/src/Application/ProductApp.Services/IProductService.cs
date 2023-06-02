using ProductApp.Dto.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Services
{
    public interface IProductService
    {
        IEnumerable<ProductDisplayResponse> GetProductsResponse();
        IEnumerable<ProductDisplayResponse> GetProductByCategory(int categoryId);

    }
}
