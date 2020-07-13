using ShoppingListMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingListMVC.Data_Access
{
  public class DbInitializer
  {
    public static void Initialize(ShoppingListItemsDbContext context)
    {
      context.Database.EnsureCreated();

      if (context.shoppinglistitems.Any())
      {
        return;   // DB has been seeded
      }

      var newshoppingitems = new ShoppingListItem[]
      {
        new ShoppingListItem()
        {
          name = "Bag of potatoes"
        },
        new ShoppingListItem()
        {
          name = "Cookie dough"
        }
      };

      foreach (ShoppingListItem i in newshoppingitems)
      {
        context.shoppinglistitems.Add(i);
      }

      context.SaveChanges();


    }

  }
}
