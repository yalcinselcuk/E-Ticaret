using AutoMapper;
using ProductApp.Dto.Requests;
using ProductApp.Dto.Responses;
using ProductApp.Entities;
using ProductApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository _productRepository, IMapper mapper)
        {
            productRepository = _productRepository;
            _mapper = mapper;
        }
        public IEnumerable<ProductDisplayResponse> GetProductsResponse()
        {
            var products = productRepository.GetAll();
            var response = _mapper.Map<IEnumerable< ProductDisplayResponse>>(products);
            return response;
        }
        public IEnumerable<ProductDisplayResponse> GetProductByCategory(int categoryId)
        {
            var products = productRepository.GetProductByCategory(categoryId);
            var response = _mapper.Map<IEnumerable<ProductDisplayResponse>>(products);
            return response;
        }

        public ProductDisplayResponse GetProduct(int id)
        {
            var product = productRepository.Get(id);
            return _mapper.Map<ProductDisplayResponse>(product);
        }

        public async Task CreateProductAsync(CreateNewProductRequest createNewProductRequest1)
        {
            var course = _mapper.Map<Product>(createNewProductRequest1);
            await productRepository.CreateAsync(course);
        }

        public async Task UpdateProduct(UpdateProductRequest updateProductRequest)
        {
            var product = _mapper.Map<Product>(updateProductRequest);
            await productRepository.UpdateAsync(product);

        }
        public async Task DeleteProduct(DeleteProductRequest deleteProductRequest)
        {
            var product = _mapper.Map<Product>(deleteProductRequest);
            await productRepository.DeleteAsync(product);

        }

        public async Task<bool> ProductIsExists(int productId)
        {
            return await productRepository.IsExistsAsync(productId);
        }

        public async Task<UpdateProductRequest> GetProductForUpdateAsync(int id)
        {
            var product = await productRepository.GetAsync(id);
            return _mapper.Map<UpdateProductRequest>(product);
        }

        public async Task<DeleteProductRequest> GetProductForDeleteAsync(int id)
        {
            var product = await productRepository.GetAsync(id);
            return _mapper.Map<DeleteProductRequest>(product);
        }

        public async Task<IEnumerable<ProductDisplayResponse>> SearchByName(string productName)
        {
            var products = await productRepository.GetProductsByName(productName);
            return _mapper.Map<IEnumerable<ProductDisplayResponse>>(products);
        }
    }
}
