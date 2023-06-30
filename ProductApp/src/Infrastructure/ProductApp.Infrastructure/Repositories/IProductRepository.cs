using ProductApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Infrastructure.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        public IEnumerable<Product> GetProductByCategory(int categoryId);
        public Task<IEnumerable<Product>> GetProductByCategoryAsync(int categoryId);

        public Task <IEnumerable<Product>> GetProductsByName(string name);
    }
}
