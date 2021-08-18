﻿using FoodOnHook.Data;
using FoodOnHook.Data.Models;
using FoodOnHook.Models;
using FoodOnHook.Models.Category;
using FoodOnHook.Models.Dish;
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
        public IActionResult All([FromQuery] AllDishesQueryModel query)
        {
            var dishesQuery = this.data.Dishes.AsQueryable();

            if (!string.IsNullOrWhiteSpace(query.Name))
            {
                dishesQuery = dishesQuery.Where(c => c.Name == query.Name);
            }

            if (!string.IsNullOrWhiteSpace(query.SearchTerm))
            {
                dishesQuery = dishesQuery.Where(c =>
                    (c.Name).ToLower().Contains(query.SearchTerm.ToLower()) ||
                    c.IngredientDescription.ToLower().Contains(query.SearchTerm.ToLower()));
            }

            dishesQuery = query.Sorting switch
            {
                DishSort.Restaurant => dishesQuery.OrderByDescending(c => c.Restaurant),
                DishSort.Category => dishesQuery.OrderByDescending(c => c.Category),
                DishSort.Name or _ => dishesQuery.OrderByDescending(c => c.Id)
            };

            var totalDishes = dishesQuery.Count();

            var dishes = dishesQuery
                .Skip((query.CurrentPage - 1) * AllDishesQueryModel.DishPerPage)
                .Take(AllDishesQueryModel.DishPerPage)
                .Select(d => new DishListViewModel
                {
                    Id = d.Id,
                    Name = d.Name,
                    Price = d.Price,
                    Discount = d.Discount,
                    Restaurant = d.Restaurant.Name,
                    Category = d.Category.Name
                })
                .ToList();

            var dishNames = this.data
                .Dishes
                .Select(d => d.Name)
                .Distinct()
                .OrderBy(n => n)
                .ToList();

            query.TotalDishes = totalDishes;
            query.Names = dishNames;
            query.Dishes = dishes;

            return View(query);
        }
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

