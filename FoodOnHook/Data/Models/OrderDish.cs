using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOnHook.Data.Models
{
    public class OrderDish
    {
        public int Id { get; init; }


        public int DishId { get; init; }

        public Dish Dish { get; init; }

        public int Quantity { get; init; }


    }
}
