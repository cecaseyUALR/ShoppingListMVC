using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingListMVC.Migrations
{
    public partial class removedguidfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_shoppinglistitems",
                table: "shoppinglistitems");

            migrationBuilder.DropColumn(
                name: "guid",
                table: "shoppinglistitems");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "shoppinglistitems",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_shoppinglistitems",
                table: "shoppinglistitems",
                column: "name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_shoppinglistitems",
                table: "shoppinglistitems");

            migrationBuilder.DeleteData(
                table: "shoppinglistitems",
                keyColumn: "name",
                keyValue: "Bread");

            migrationBuilder.DeleteData(
                table: "shoppinglistitems",
                keyColumn: "name",
                keyValue: "Eggs");

            migrationBuilder.DeleteData(
                table: "shoppinglistitems",
                keyColumn: "name",
                keyValue: "Milk");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "shoppinglistitems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<Guid>(
                name: "guid",
                table: "shoppinglistitems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_shoppinglistitems",
                table: "shoppinglistitems",
                column: "guid");

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
    }
}
