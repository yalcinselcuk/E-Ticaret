using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ProductApp.Infrastructure.Data;
using ProductApp.Infrastructure.Repositories;
using ProductApp.Services;

namespace ProductApp.Mvc.Extensions
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddInjections(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IProductService, ProductService>();//calisacaği servisi söyledik
            services.AddScoped<IProductRepository, EFProductRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, EFCategoryRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddDbContext<ProductDbContext>(option => option.UseSqlServer(connectionString));
            return services;
        }
    }
}
