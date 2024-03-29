﻿namespace BurgerWebApp.DomainModels
{
    public class Burger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }
        public string Image { get; set; }
        public string Ingredients { get; set; }
        public string Description { get; set; }
        public Burger()
        {

        }
        public Burger(string name, decimal price, bool isVegetarian, bool hasFries, string image, bool isVegan, string ingredients, string description)
        {

            Name = name;
            Price = price;
            IsVegetarian = isVegetarian;
            HasFries = hasFries;
            Image = image;
            IsVegan = isVegan;
            Ingredients = ingredients;
            Description = description;
        }


    }
}
