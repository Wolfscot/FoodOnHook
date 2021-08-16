using FoodOnHook.Models.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static FoodOnHook.Data.ModelConstants.Dish;

namespace FoodOnHook.Models
{
    public class DishFormModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; }

        [Required]
        [Range(GramsMin, GramsMax)]
        public double Grams { get; set; }

        [Required]
        [Range(PriceMin, Double.MaxValue)]
        public double Price { get; set; }

        [Required]
        [Range(DiscountMin, DiscountMax)]
        public double Discount { get; set; }

        [Display(Name = "Ingredients")]
        [Required]
        [StringLength(
            int.MaxValue,
            MinimumLength = IngredientsMinLength,
            ErrorMessage = "Fill at least one ingredient {5}.")]
        public string IngredientDescription { get; init; }

        [Display(Name = "Image URL")]
        [Required]
        [Url]
        public string ImageUrl { get; init; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }


        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
