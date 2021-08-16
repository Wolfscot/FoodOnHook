using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static FoodOnHook.Data.ModelConstants.Restaurant;

namespace FoodOnHook.Data.Models
{
    public class Restaurant
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; }

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }

        public int CousineId { get; set; }

        public Cousine Cousine { get; init; }

        [Required]
        public string ImageUrl { get; set; }

        public int Rating { get; set; }  

        public DateTime Open { get; set; }
        public DateTime Close { get; set; }

        [Required]
        public string UserId { get; set; }

        public IEnumerable<Dish> Dishes { get; init; } = new List<Dish>();

        public IEnumerable<Order> Orders { get; init; } = new List<Order>();
    }
}
