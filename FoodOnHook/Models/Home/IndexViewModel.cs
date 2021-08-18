using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOnHook.Models.Home
{
    public class IndexViewModel
    {
        public int TotalDishes { get; init; }

        public int TotalUsers { get; init; }

        public int TotalOrders { get; init; }

        public List<DishIndexViewModel> Dishes { get; init; }
    }
}
