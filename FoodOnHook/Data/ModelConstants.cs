using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOnHook.Data
{
    public class ModelConstants
    {
        public class User
        {
            public const int FullNameMinLength = 5;
            public const int FullNameMaxLength = 20;
            public const int PasswordMinLength = 6;
            public const int PasswordMaxLength = 12;
        }

        public class Dish
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 25;
            public const int QuantityMin = 1;
            public const int QuantityMax = 50;
            public const double GramsMin = 50;
            public const double GramsMax = 5000;
            public const double PriceMin = 0;
            public const double DiscountMin = 0;
            public const double DiscountMax = 0.75;
            public const int IngredientsMinLength = 5;
        }
        public class Category
        {
            public const int NameMaxLength = 20;
        }

        public class Restaurant
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 25;
            public const int AddressMinLength = 10;
            public const int AddressMaxLength = 50;
            public const int PhoneNumberMinLength = 10;
            public const int PhoneNumberMaxLength = 30;
        }

        public class Classification
        {
            public const int NameMaxLength = 20;
        }


        public class DeliveryMethod
        {
            public const int NameMaxLength = 10;
        }
    }
}
