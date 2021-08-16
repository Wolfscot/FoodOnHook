
using FoodOnHook.Data;
using FoodOnHook.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOnHook.Infrastructure
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<FoodOnHookDbContext>();

            data.Database.Migrate();

            SeedCategories(data);

            return app;
        }

        private static void SeedCategories(FoodOnHookDbContext data)
        {
            if (data.Categories.Any())
            {
                return;
            }

            data.Categories.AddRange(new[]
            {
                new Category { Name = "Soup" },
                new Category { Name = "Salad" },
                new Category { Name = "Fish" },
                new Category { Name = "Pasta & Noodles" },
                new Category { Name = "Pizza" },
                new Category { Name = "Chicken" },
                new Category { Name = "Stew" },
                new Category { Name = "Beef" },
                new Category { Name = "Pork" },
                new Category { Name = "Burger" },
                new Category { Name = "BBQ" },
                new Category { Name = "Sandwitch" },
                new Category { Name = "Side Dish" },                
                new Category { Name = "Main dish" },
                new Category { Name = "Dessert" },
                new Category { Name = "Apetizer and Starter" }


            });

            data.SaveChanges();
        }
    }
}
