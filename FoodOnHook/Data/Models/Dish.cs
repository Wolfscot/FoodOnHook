using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static FoodOnHook.Data.ModelConstants.Dish;

namespace FoodOnHook.Data.Models
{
    public class Dish
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }      

        [Required]
        public double Grams { get; set; }
        [Required]
        public double Price { get; set; }

        public double Discount { get; set; }

        [Required]
        public string IngredientDescription { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; init; }

        public int RestaurantId { get; init; }

        public Restaurant Restaurant { get; init; }

        public int OrderDishId { get; init; }

        public OrderDish OrderDish { get; init; }

    }
}
