using FoodOnHook.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOnHook.Infrastructure;
using static FoodOnHook.Data.Models.Restaurant;
using FoodOnHook.Data.Models;
using FoodOnHook.Models.Restaurant;
using FoodOnHook.Models.Cousine;

namespace FoodOnHook.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly FoodOnHookDbContext data;

        public RestaurantController(FoodOnHookDbContext data)
            => this.data = data;

        [Authorize]
        public IActionResult RestaurantOwner() => View();

        [HttpPost]
        [Authorize]
        public IActionResult RestaurantOwner(RestaurantOwnerFormModel restaurant)
        {
            var userId = this.User.GetId();

            var userIdAlreadyOwner = this.data
                .Restaurants
                .Any(r => r.UserId == userId);

            if (userIdAlreadyOwner)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(restaurant);
            }

            var restaurantData = new Restaurant
            {
                Name = restaurant.Name,
                Address = restaurant.Address,
                PhoneNumber = restaurant.PhoneNumber,
                ImageUrl = restaurant.ImageUrl,
                CousineId = restaurant.CousineId,
                UserId = userId
            };

            this.data.Restaurants.Add(restaurantData);
            this.data.SaveChanges();

            return RedirectToAction("All", "Dishes");
        }

        private IEnumerable<CousineViewModel> GetCousines()
          => this.data
              .Cousines
              .Select(c => new CousineViewModel
              {
                  Id = c.Id,
                  Name = c.Name
              })
              .ToList();
    }
}
