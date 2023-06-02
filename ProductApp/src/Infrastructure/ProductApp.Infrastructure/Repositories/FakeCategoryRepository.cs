using ProductApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Infrastructure.Repositories
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        private List<Category> _categories;
        public FakeCategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category{Id=1, CategoryName="Computers"},
                new Category{Id=2, CategoryName="Tablets"},
                new Category{Id=3, CategoryName="Phones"}
            };
        }
        public Category? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Category?> GetAll()
        {
            return _categories;
        }

        public Task<IList<Category?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
