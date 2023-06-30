using Microsoft.EntityFrameworkCore;
using ProductApp.Entities;
using ProductApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Infrastructure.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ProductDbContext productDbContext;
        public EFProductRepository(ProductDbContext productDbContext)
        {
            this.productDbContext = productDbContext;
        }
        public async Task CreateAsync(Product entity)
        {
            await productDbContext.Products.AddAsync(entity);
            await productDbContext.SaveChangesAsync();
        }

        //public async Task DeleteAsync(int id)
        //{
        //    var deletingCourse = await productDbContext.Products.FindAsync(id);
        //    productDbContext.Products.Remove(deletingCourse);
        //    await productDbContext.SaveChangesAsync();
        //}
        public async Task DeleteAsync(Product entity)
        {
            var deletingCourse = await productDbContext.Products.FindAsync(entity.Id);
            productDbContext.Products.Remove(deletingCourse);
            await productDbContext.SaveChangesAsync();
        }

        public Product? Get(int id)
        {
            return productDbContext.Products.FirstOrDefault(c => c.Id == id);
        }

        public IList<Product?> GetAll()
        {
            return productDbContext.Products.AsNoTracking().ToList();
        }

        public async Task<IList<Product?>> GetAllAsync()
        {
            return await productDbContext.Products.AsNoTracking().ToListAsync();
        }

        public IList<Product> GetAllWithPredicate(Expression<Func<Product, bool>> predicate)
        {
            return productDbContext.Products.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<Product?> GetAsync(int id)
        {
            return await productDbContext.Products.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }

        public IEnumerable<Product> GetProductByCategory(int categoryId)
        {
            return productDbContext.Products.AsNoTracking().Where(c => c.CategoryId == categoryId).AsEnumerable();
        }

        public async Task<IEnumerable<Product>> GetProductByCategoryAsync(int categoryId)
        {
            return await productDbContext.Products.AsNoTracking().Where(c => c.CategoryId == categoryId).ToListAsync();

        }

        public async Task<IEnumerable<Product>> GetProductsByName(string name)
        {
            return await productDbContext.Products.AsNoTracking().Where(c => c.Name.Contains(name)).ToListAsync();

        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await productDbContext.Products.AnyAsync(c => c.Id == id);
        }

        public async Task UpdateAsync(Product entity)
        {
            productDbContext.Products.Update(entity);
            await productDbContext.SaveChangesAsync();
        }
    }
}
