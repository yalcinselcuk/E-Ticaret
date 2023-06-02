﻿using AutoMapper;
using ProductApp.Dto.Responses;
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
    }
}
