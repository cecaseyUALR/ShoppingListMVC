using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ShoppingListMVC.Data_Access;
using ShoppingListMVC.Models;

namespace ShoppingListMVC
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = CreateHostBuilder(args).Build();

      using (var scope = host.Services.CreateScope())
      {
        var services = scope.ServiceProvider;
        try
        {
          var context = services.GetRequiredService<ShoppingListItemsDbContext>();
          DbInitializer.Initialize(context);
        }
        catch (Exception ex)
        {
          var logger = services.GetRequiredService<ILogger<Program>>();
          logger.LogError(ex, "An error occurred while seeding the database.");
        }
      }

      host.Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }

  public class ShoppingListItemsDbContext : DbContext
  {
    public DbSet<ShoppingListItem> shoppinglistitems { get; set; }

    public ShoppingListItemsDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      // generate dummy data
      //  modelBuilder.Entity<ShoppingListItem>().HasData(
      //    new ShoppingListItem() { name = "Eggs", iscompleted = false },  
      //    new ShoppingListItem() { name = "Milk", iscompleted = false },  
      //    new ShoppingListItem() { name = "Bread", iscompleted = false });
    }
  }
}
