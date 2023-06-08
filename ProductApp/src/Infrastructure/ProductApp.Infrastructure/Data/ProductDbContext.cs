using Microsoft.EntityFrameworkCore;
using ProductApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Infrastructure.Data
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get;set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
    }
}
