using AutoMapper;
using ProductApp.Dto.Requests;
using ProductApp.Dto.Responses;
using ProductApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Services.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile() 
        {
            CreateMap<Product, ProductDisplayResponse>();
            CreateMap<Category, CategoryDisplayResponse>();
            CreateMap<CreateNewProductRequest, Product>();
        }
    }
}
