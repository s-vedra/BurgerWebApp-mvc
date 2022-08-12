using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerWebApp.DataAccess.Migrations
{
    public partial class updatetext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burger",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A hamburger is a food consisting of fillings —usually a patty of ground meat, typically beef—placed inside a sliced bun or bread roll. 250kcal / 1046kJ");

            migrationBuilder.UpdateData(
                table: "Burger",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "A veggie burger is a hamburger patty that does not contain meat. It may be made from ingredients like beans, especially soybeans and tofu, nuts, grains, seeds or fungi such as mushrooms or mycoprotein. 177kcal / 741kJ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burger",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "A hamburger is a food consisting of fillings —usually a patty of ground meat, typically beef—placed inside a sliced bun or bread roll.250kcal / 1046kJ");

            migrationBuilder.UpdateData(
                table: "Burger",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "A veggie burger is a hamburger patty that does not contain meat. It may be made from ingredients like beans, especially soybeans and tofu, nuts, grains, seeds or fungi such as mushrooms or mycoprotein, 177kcal, 741kJ");
        }
    }
}
