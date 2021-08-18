using FoodOnHook.Data;
using FoodOnHook.Models;
using FoodOnHook.Models.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOnHook.Controllers
{
    public class HomeController : Controller
    {
        private readonly FoodOnHookDbContext data;

        public HomeController(FoodOnHookDbContext data)
            => this.data = data;

        public IActionResult Index()
        {
            var totaldishes = this.data.Dishes.Count();

            var dishes = this.data
                .Dishes
                .OrderByDescending(c => c.Id)
                .Select(d => new DishIndexViewModel
                {
                    Id = d.Id,
                    Name = d.Name,
                    Price = d.Price,
                    Restaurant = d.Restaurant.Name,
                    ImageUrl = d.ImageUrl
                })
                .Take(3)
                .ToList();

            return View(new IndexViewModel
            {
                TotalDishes = totaldishes,
                Dishes = dishes
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
