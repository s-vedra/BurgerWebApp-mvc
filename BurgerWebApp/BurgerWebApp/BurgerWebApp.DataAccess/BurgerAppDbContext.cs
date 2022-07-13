using BurgerWebApp.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace BurgerWebApp.DataAccess
{
    public class BurgerAppDbContext : DbContext
    {
        public BurgerAppDbContext(DbContextOptions<BurgerAppDbContext> options) : base(options)
        {

        }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<BurgerOrder> BurgerOrders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<ExtrasOrder> ExtraOrders { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Size> Sizes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Burger>().ToTable("Burger");
            builder.Entity<Cart>().ToTable("Cart");
            builder.Entity<Location>().ToTable("Location");
            builder.Entity<Order>().ToTable("Order");
            builder.Entity<Extra>().ToTable("Extra");
            builder.Entity<BurgerOrder>().ToTable("BurgerOrder");
            builder.Entity<ExtrasOrder>().ToTable("ExtraOrder");
            builder.Entity<Size>().ToTable("Size");

            builder.Entity<Burger>().HasData(
                    new Burger("Hamburger", 100, false, true, "https://tastesbetterfromscratch.com/wp-content/uploads/2020/06/Classic-Juicy-Hamburger-Recipe-Square.jpg", false)
                    {
                        Id = 1
                    },
                    new Burger("Cheeseburger", 120, false, true, "https://www.kitchensanctuary.com/wp-content/uploads/2021/05/Double-Cheeseburger-square-FS-42.jpg", false)
                    {
                        Id = 2
                    },
                    new Burger("Chickenburger", 120, false, true, "https://images.unsplash.com/photo-1590498403794-fd0ebd0db70c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", false)
                    {
                        Id = 3
                    },
                    new Burger("Vegeterian Dish", 220, true, true, "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/halloumi-burger-4fdad97.jpg", false)
                    {
                        Id = 4
                    },
                    new Burger("Veggie Burger", 250, true, true, "https://thedinnerbell.recipes/wp-content/uploads/2019/11/Edamame-Mushroom-Veggie-Burgers-9.jpg", true)
                    {
                        Id = 5
                    }
                );
            builder.Entity<Extra>().HasData(
                    new Extra("Small Fries", "https://images.immediate.co.uk/production/volatile/sites/30/2021/03/French-fries-b9e3e0c.jpg", 1)
                    {
                        Id = 1
                    },

                    new Extra("Medium Fries", "https://images.immediate.co.uk/production/volatile/sites/30/2021/03/French-fries-b9e3e0c.jpg", 2)
                    {
                        Id = 2
                    },

                    new Extra("Large Fries", "https://images.immediate.co.uk/production/volatile/sites/30/2021/03/French-fries-b9e3e0c.jpg", 3)
                    {
                        Id = 3
                    },
                    new Extra("Small Coke", "https://www.kwiberry.com/pohojar/2022/02/000145352.jpeg", 1)
                    {
                        Id = 4
                    },
                    new Extra("Medium Coke", "https://www.kwiberry.com/pohojar/2022/02/000145352.jpeg", 2)
                    {
                        Id = 5
                    },
                    new Extra("Large Coke", "https://www.kwiberry.com/pohojar/2022/02/000145352.jpeg", 3)
                    {
                        Id = 6
                    }
                );
            builder.Entity<Location>().HasData(
                    new Location("Hamm Burger", "BurgerStreet1", new DateTime(2022, 1, 1, 8, 00, 00), new DateTime(2022, 1, 1, 23, 00, 00))
                    {
                        Id = 1
                    },
                    new Location("Burger Place", "BurgerStreet2", new DateTime(2022, 1, 1, 8, 00, 00), new DateTime(2022, 1, 1, 23, 00, 00))
                    {
                        Id = 2
                    },
                    new Location("Burger Palace", "BurgerStreet3", new DateTime(2022, 1, 1, 8, 00, 00), new DateTime(2022, 1, 1, 23, 00, 00))
                    {
                        Id = 3
                    },
                    new Location("Burger World", "BurgerStreet4", new DateTime(2022, 1, 1, 8, 00, 00), new DateTime(2022, 1, 1, 23, 00, 00))
                    {
                        Id = 4
                    },
                    new Location("Burger Place Two", "BurgerStreet5", new DateTime(2022, 1, 1, 8, 00, 00), new DateTime(2022, 1, 1, 23, 00, 00))
                    {
                        Id = 5
                    }
                );
            builder.Entity<Size>().HasData(
                    new Size("Small", 50)
                    {
                        Id = 1
                    },
                    new Size("Medium", 70)
                    {
                        Id = 2
                    },
                    new Size("Large", 100)
                    { 
                        Id = 3
                    }
                );
        }
    }
}
