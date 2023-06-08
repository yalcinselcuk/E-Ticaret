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
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly ProductDbContext productDbContext;
        public EFCategoryRepository(ProductDbContext productDbContext)
        {
            this.productDbContext = productDbContext;
        }

        public async Task CreateAsync(Category entity)
        {
            await productDbContext.Categories.AddAsync(entity);
            await productDbContext.SaveChangesAsync();
        }

        public async Task DeleteAync(int id)
        {
            var deletingCategory = await productDbContext.Categories.FindAsync(id);
            productDbContext.Categories.Remove(deletingCategory);
            await productDbContext.SaveChangesAsync();
        }

        public Category? Get(int id)
        {
            return productDbContext.Categories.FirstOrDefault(c => c.Id == id);
        }

        public IList<Category?> GetAll()
        {
            return productDbContext.Categories.AsNoTracking().ToList();
        }

        public async Task<IList<Category?>> GetAllAsync()
        {
            return await productDbContext.Categories.AsNoTracking().ToListAsync();
        }

        public IList<Category> GetAllWithPredicate(Expression<Func<Category, bool>> predicate)
        {
            return productDbContext.Categories.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<Category?> GetAsync(int id)
        {
            return await productDbContext.Categories.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<bool> IsExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Category entity)
        {
            productDbContext.Categories.Update(entity);
            await productDbContext.SaveChangesAsync();
        }
    }
}
