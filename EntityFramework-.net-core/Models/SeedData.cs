using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace EntityFramework_.net_core.Models
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Products.Any())
            {

                context.Products.AddRange(
                    new Product() { Name = "Product 1", Desc = "Phone 1", Price = 150, Category = "Phone 1" },
                    new Product() { Name = "Product 2", Desc = "Phone 2", Price = 200, Category = "Phone 2" },
                    new Product() { Name = "Product 3", Desc = "Phone 3", Price = 250, Category = "Phone 3" },
                    new Product() { Name = "Product 4", Desc = "Phone 4", Price = 300, Category = "Phone 4" },
                    new Product() { Name = "Product 5", Desc = "Phone 5", Price = 350, Category = "Phone 5" }
                    );

                context.SaveChanges();
            }
        }
    }
}
