using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOnHook.Models.Home
{
    public class DishIndexViewModel
    {
        public int Id { get; init; }
        public string Name { get; init; }

        public double Price { get; init; }
        
        public string ImageUrl { get; init; }

        public string Restaurant { get; init; }


    }
}
