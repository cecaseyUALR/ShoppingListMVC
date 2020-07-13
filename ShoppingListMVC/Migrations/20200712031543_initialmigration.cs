using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingListMVC.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shoppinglistitems",
                columns: table => new
                {
                    guid = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    iscompleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoppinglistitems", x => x.guid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shoppinglistitems");
        }
    }
}
