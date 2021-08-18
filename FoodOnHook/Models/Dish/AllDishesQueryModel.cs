using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOnHook.Models.Dish
{
    public class AllDishesQueryModel
    {
        public const int DishPerPage = 3;

        public string Name { get; init; }

        [Display(Name = "Search by text")]
        public string SearchTerm { get; init; }

        public DishSort Sorting { get; init; }

        public int CurrentPage { get; init; } = 1;

        public int TotalDishes { get; set; }

        public IEnumerable<string> Names { get; set; }

        public IEnumerable<DishListViewModel> Dishes { get; set; }
    }
}
