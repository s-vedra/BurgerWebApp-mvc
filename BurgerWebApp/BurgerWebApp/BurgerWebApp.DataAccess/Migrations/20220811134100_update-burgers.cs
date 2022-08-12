using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerWebApp.DataAccess.Migrations
{
    public partial class updateburgers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Burger",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Burger",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Burger",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Ingredients" },
                values: new object[] { "A hamburger is a food consisting of fillings —usually a patty of ground meat, typically beef—placed inside a sliced bun or bread roll.250kcal / 1046kJ", "Regular Bun, 100% Beef Patty, Ketchup, Pickle Slices, Onions, Mustard" });

            migrationBuilder.UpdateData(
                table: "Burger",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Ingredients" },
                values: new object[] { "A cheeseburger is a hamburger topped with cheese. Traditionally, the slice of cheese is placed on top of the meat patty. The cheese is usually added to the cooking hamburger patty shortly before serving, which allows the cheese to melt. Cheeseburgers can include variations in structure, ingredients and composition. 303kcal / 1268kJ", "Regular Bun, 100% Beef Patty, Pasteurized Process American Cheese, Ketchup, Pickle Slices, Onions, Mustard" });

            migrationBuilder.UpdateData(
                table: "Burger",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Ingredients" },
                values: new object[] { "A chicken burger is a burger that typically consists of boneless, skinless chicken breast or thigh served between slices of bread, on a bun, or on a roll. Variations on the chicken burger include the chicken burger, chicken on a bun, chickwich, hot chicken, or chicken salad sandwich. 330 kcal / 1388 kJ ", "Regular Bun, Mayonnaise, Lettuce, Value Chicken Patty" });

            migrationBuilder.UpdateData(
                table: "Burger",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Ingredients" },
                values: new object[] { "The vegetarian-based burger contains a battered and breaded patty which is made of peas, corn, carrots, green beans, onions, potatoes, rice and spices, served in a sesame toasted bun with eggless mayonnaise and lettuce. 360kcal / 1507kJ", "Chickpeas, Sweetcorn, Fresh coriander, Paprika, Tomatoes, Ketchup, Burger buns" });

            migrationBuilder.UpdateData(
                table: "Burger",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Ingredients" },
                values: new object[] { "A veggie burger is a hamburger patty that does not contain meat. It may be made from ingredients like beans, especially soybeans and tofu, nuts, grains, seeds or fungi such as mushrooms or mycoprotein, 177kcal, 741kJ", "Sweet potatoes, Quinoa, Black beans, Red onion, cilantro, and garlic, Spices, Quick-cooking oats" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Burger");

            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Burger");
        }
    }
}
