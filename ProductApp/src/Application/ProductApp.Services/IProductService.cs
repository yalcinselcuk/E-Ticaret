using ProductApp.Dto.Requests;
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
        ProductDisplayResponse GetProduct(int id);

        Task<UpdateProductRequest> GetProductForUpdateAsync(int id);
        IEnumerable<ProductDisplayResponse> GetProductsResponse();
        IEnumerable<ProductDisplayResponse> GetProductByCategory(int categoryId);
        Task CreateProductAsync(CreateNewProductRequest createNewProductRequest1);

        Task UpdateProduct(UpdateProductRequest updateProductRequest);
        Task<bool> ProductIsExists(int productId);

    }
}
