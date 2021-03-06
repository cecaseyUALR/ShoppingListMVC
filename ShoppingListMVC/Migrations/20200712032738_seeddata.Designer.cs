﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingListMVC;

namespace ShoppingListMVC.Migrations
{
    [DbContext(typeof(ShoppingListItemsDbContext))]
    [Migration("20200712032738_seeddata")]
    partial class seeddata
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
                    b.Property<Guid>("guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("iscompleted")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("guid");

                    b.ToTable("shoppinglistitems");

                    b.HasData(
                        new
                        {
                            guid = new Guid("d7108c85-1532-4dff-8225-c3abe5c318b1"),
                            iscompleted = false,
                            name = "Eggs"
                        },
                        new
                        {
                            guid = new Guid("514b6bb2-a8b7-48bd-a779-e7b109efca7c"),
                            iscompleted = false,
                            name = "Milk"
                        },
                        new
                        {
                            guid = new Guid("5e2fb8c7-2ae9-4476-bc9f-5fca89ca586a"),
                            iscompleted = false,
                            name = "Bread"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
