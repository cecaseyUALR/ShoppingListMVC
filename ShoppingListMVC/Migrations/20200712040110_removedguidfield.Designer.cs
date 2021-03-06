﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingListMVC;

namespace ShoppingListMVC.Migrations
{
    [DbContext(typeof(ShoppingListItemsDbContext))]
    [Migration("20200712040110_removedguidfield")]
    partial class removedguidfield
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShoppingListMVC.Models.ShoppingListItem", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("iscompleted")
                        .HasColumnType("bit");

                    b.HasKey("name");

                    b.ToTable("shoppinglistitems");

                    b.HasData(
                        new
                        {
                            name = "Eggs",
                            iscompleted = false
                        },
                        new
                        {
                            name = "Milk",
                            iscompleted = false
                        },
                        new
                        {
                            name = "Bread",
                            iscompleted = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
