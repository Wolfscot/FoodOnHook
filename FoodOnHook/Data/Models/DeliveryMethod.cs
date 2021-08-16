using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static FoodOnHook.Data.ModelConstants.DeliveryMethod;


namespace FoodOnHook.Data.Models
{
    public class DeliveryMethod
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public IEnumerable<Order> Orders { get; init; } = new List<Order>();

    }
}
