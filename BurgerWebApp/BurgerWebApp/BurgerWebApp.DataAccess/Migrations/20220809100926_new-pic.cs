using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerWebApp.DataAccess.Migrations
{
    public partial class newpic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Burger",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://images.unsplash.com/photo-1585238341267-1cfec2046a55?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=574&q=80");

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Address", "ClosesAt", "Image", "Name", "OpensAt" },
                values: new object[,]
                {
                    { 1, "BurgerStreet1", new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", "Hamm Burger", new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "BurgerStreet2", new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", "Burger Place", new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "BurgerStreet3", new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", "Burger Palace", new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "BurgerStreet4", new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", "Burger World", new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "BurgerStreet5", new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", "Burger Place Two", new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Burger",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://thedinnerbell.recipes/wp-content/uploads/2019/11/Edamame-Mushroom-Veggie-Burgers-9.jpg");

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "Address", "ClosesAt", "Image", "Name", "OpensAt" },
                values: new object[,]
                {
                    { 1, "BurgerStreet1", new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", "Hamm Burger", new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "BurgerStreet2", new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", "Burger Place", new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "BurgerStreet3", new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", "Burger Palace", new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "BurgerStreet4", new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", "Burger World", new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "BurgerStreet5", new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80", "Burger Place Two", new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
