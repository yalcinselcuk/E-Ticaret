using ProductApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Infrastructure.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        private List<Product> _products;

        public FakeProductRepository() 
        {
            _products = new()
            {
                new Product{Id=1, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=1, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=1, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=1, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 }
            };
        }
        public Product? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product?> GetAll()
        {
            return _products;
        }

        public Task<IList<Product?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetCoursesByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
