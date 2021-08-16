
using FoodOnHook.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodOnHook.Data
{
    public class FoodOnHookDbContext : IdentityDbContext
    {
        public FoodOnHookDbContext(DbContextOptions<FoodOnHookDbContext> options)
            : base(options)
        {
        }

        

        public DbSet<Dish> Dishes { get; init; }

        public DbSet<Category> Categories { get; init; }

        public DbSet<Restaurant> Restaurants { get; init; }

        public DbSet<Cousine> Cousines { get; init; }

        public DbSet<Order> Orders { get; init; }

        public DbSet<OrderDish> OrderDishes { get; init; }

        public DbSet<DeliveryMethod> DeliveryMethods { get; init; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Dish>()
                .HasOne(c => c.Category)
                .WithMany(d => d.Dishes)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);


            builder
                .Entity<OrderDish>()
                .HasOne(d => d.Dish)
                .WithOne(o=>o.OrderDish)
                .HasForeignKey<OrderDish>(d => d.DishId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Dish>()
                .HasOne(r => r.Restaurant)
                .WithMany(d => d.Dishes)
                .HasForeignKey(r => r.RestaurantId)
                .OnDelete(DeleteBehavior.Restrict);
            builder
               .Entity<Order>()
               .HasOne(r => r.Restaurant)
               .WithMany(d => d.Orders)
               .HasForeignKey(r => r.RestaurantId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Restaurant>()
                .HasOne(c => c.Cousine)
                .WithMany(d => d.Restaurants)
                .HasForeignKey(c => c.CousineId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Order>()
                .HasOne(r => r.Restaurant)
                .WithMany(o => o.Orders)
                .HasForeignKey(r => r.RestaurantId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<Order>()
               .HasOne(d => d.DeliveryMethod)
               .WithMany(o => o.Orders)
               .HasForeignKey(d => d.DeliveryMethodId)
               .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
