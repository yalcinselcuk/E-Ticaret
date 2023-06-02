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
                new Product{Id=2, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=3, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=4, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=5, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=6, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=7, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=8, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=9, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=10, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=11, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=12, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=13, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=14, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=15, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=16, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=17, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=18, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=19, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=20, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=21, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=22, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=23, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 },
                new Product{Id=24, Name="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Description="Xiaomi Redmi Pad 6 GB Ram 128 GB Tablet - Gri", Price=6079 }
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
