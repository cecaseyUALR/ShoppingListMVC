using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingListMVC.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "shoppinglistitems",
                columns: new[] { "guid", "iscompleted", "name" },
                values: new object[] { new Guid("d7108c85-1532-4dff-8225-c3abe5c318b1"), false, "Eggs" });

            migrationBuilder.InsertData(
                table: "shoppinglistitems",
                columns: new[] { "guid", "iscompleted", "name" },
                values: new object[] { new Guid("514b6bb2-a8b7-48bd-a779-e7b109efca7c"), false, "Milk" });

            migrationBuilder.InsertData(
                table: "shoppinglistitems",
                columns: new[] { "guid", "iscompleted", "name" },
                values: new object[] { new Guid("5e2fb8c7-2ae9-4476-bc9f-5fca89ca586a"), false, "Bread" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "shoppinglistitems",
                keyColumn: "guid",
                keyValue: new Guid("514b6bb2-a8b7-48bd-a779-e7b109efca7c"));

            migrationBuilder.DeleteData(
                table: "shoppinglistitems",
                keyColumn: "guid",
                keyValue: new Guid("5e2fb8c7-2ae9-4476-bc9f-5fca89ca586a"));

            migrationBuilder.DeleteData(
                table: "shoppinglistitems",
                keyColumn: "guid",
                keyValue: new Guid("d7108c85-1532-4dff-8225-c3abe5c318b1"));
        }
    }
}
