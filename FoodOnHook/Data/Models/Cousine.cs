using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static FoodOnHook.Data.ModelConstants.Dish;

namespace FoodOnHook.Data.Models
{
    public class Cousine
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public IEnumerable<Restaurant> Restaurants { get; init; } = new List<Restaurant>();
    }
}
