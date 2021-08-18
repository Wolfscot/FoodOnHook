using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOnHook.Models.Dish
{
    public class DishListViewModel
    {
        public int Id { get; init; }
        public string Name { get; set; }  
       
        public double Price { get; set; }

        public double Discount { get; set; } 
        public string ImageUrl { get; set; }

        public string Category { get; set; }       

        public string Restaurant { get; init; }

        
    }
}
