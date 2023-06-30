using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ProductApp.Infrastructure.Data;
using ProductApp.Infrastructure.Repositories;
using ProductApp.Services;
using ProductApp.Services.Mappings;

namespace ProductApp.API.Extensions
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
            services.AddAutoMapper(typeof(MapProfile));

            services.AddDbContext<ProductDbContext>(option => option.UseSqlServer(connectionString));
            return services;
        }
    }
}
