using FoodOnHook.Data;
using FoodOnHook.Data.Models;
using FoodOnHook.Models;
using FoodOnHook.Models.Category;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOnHook.Controllers
{
    public class DishController : Controller
    {
        private readonly FoodOnHookDbContext data;

        public DishController(FoodOnHookDbContext data)
            => this.data = data;

        public IActionResult Add() => View(new DishFormModel
        {
            Categories = this.GetCategories()
        });

        [HttpPost]
        public IActionResult Add(DishFormModel dish)
        {
            if (!this.data.Categories.Any(d => d.Id == dish.CategoryId))
            {
                this.ModelState.AddModelError(nameof(dish.CategoryId), "There is no such a category");
            }

            if (!ModelState.IsValid)
            {
                dish.Categories = this.GetCategories();

                return View(dish);
            }

            var dishData = new Dish
            {

                Name = dish.Name,                
                Grams = dish.Grams,
                Price = dish.Price,
                Discount = dish.Discount,
                IngredientDescription = dish.IngredientDescription,
                ImageUrl = dish.ImageUrl,
                CategoryId = dish.CategoryId
            };

            this.data.Dishes.Add(dishData);
            this.data.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        private IEnumerable<CategoryViewModel> GetCategories()
            => this.data
                .Categories
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToList();
    }
}

