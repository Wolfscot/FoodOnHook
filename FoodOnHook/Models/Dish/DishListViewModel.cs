using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOnHook.Models.Dish
{
    public class DishListViewModel
    {
        public int Id { get; init; }
        public string Name { get; init; }

        public double Price { get; init; }

        public double Discount { get; init; }
        public string ImageUrl { get; init; }

        public string Category { get; init; }

        public string Restaurant { get; init; }


    }
}
