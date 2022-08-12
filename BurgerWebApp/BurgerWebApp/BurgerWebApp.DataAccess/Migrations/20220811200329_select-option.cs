using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerWebApp.DataAccess.Migrations
{
    public partial class selectoption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Selected",
                table: "BurgerOrder");

            migrationBuilder.AddColumn<bool>(
                name: "Select",
                table: "Burger",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Select",
                table: "Burger");

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "BurgerOrder",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
