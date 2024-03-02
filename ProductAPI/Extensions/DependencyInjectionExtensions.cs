using Microsoft.EntityFrameworkCore;
using ProductAPI.Datas;
using ProductAPI.Repositories;
using ProductCore.Models;

namespace ProductAPI.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void InjectDependancies(this WebApplicationBuilder builder)
        {
            builder.AddDatabase();
            builder.AddRepositories();
        }

        private static void AddDatabase(this WebApplicationBuilder builder)
        {
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
        }
        private static void AddRepositories(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IRepository<Product>, ProductRepository>();
        }
    }
}
