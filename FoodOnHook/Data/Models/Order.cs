using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOnHook.Data.Models
{
    public class Order
    {
        [Required]
        public int Id { get; init; }

        [Required]
        public int RestaurantId { get; init; }

        public Restaurant Restaurant { get; init; }

        public IEnumerable<OrderDish> OrderDishes { get; init; } = new List<OrderDish>();

        public int DeliveryMethodId { get; init; }

        public DateTime OrderTime { get; init; }

        public DeliveryMethod DeliveryMethod { get; init; }

        public decimal Delivery { get; init; }

        [Required]
        public decimal Bill { get; init; }

        [Required]
        public string UserId { get; set; }


    }
}
