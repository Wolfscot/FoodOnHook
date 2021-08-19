using FoodOnHook.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult RestaurantOwner(RestaurantOwnerForm dealer)
        {
            var userId = this.User.GetId();

            var userIdAlreadyDealer = this.data
                .Dealers
                .Any(d => d.UserId == userId);

            if (userIdAlreadyDealer)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(dealer);
            }

            var dealerData = new Dealer
            {
                Name = dealer.Name,
                PhoneNumber = dealer.PhoneNumber,
                UserId = userId
            };

            this.data.Dealers.Add(dealerData);
            this.data.SaveChanges();

            return RedirectToAction("All", "Cars");
        }
}
