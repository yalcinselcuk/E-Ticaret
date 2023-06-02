using AutoMapper;
using ProductApp.Dto.Responses;
using ProductApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public IEnumerable<CategoryDisplayResponse> GetCategoryDisplayResponses()
        {
            var categories = _categoryRepository.GetAll();
            var response = _mapper.Map<IEnumerable<CategoryDisplayResponse>>(categories);
            return response;
        }
    }
}
