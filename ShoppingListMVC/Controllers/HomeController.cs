using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoppingListMVC.Models;

namespace ShoppingListMVC.Controllers
{
  public class HomeController : Controller
  {
    private readonly ShoppingListItemsDbContext _context;

    public HomeController(ShoppingListItemsDbContext context)
    {
      _context = context;
    }

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    public ActionResult ShoppingList()
    {
      return View();
    }

    [HttpPost]
    public ActionResult ShoppingList(String name)
    {
      dynamic result;

      if (_context.shoppinglistitems.Find(name) == null)
      {
        var newitem = new ShoppingListItem() { name = name };
        _context.Add(newitem);
        _context.SaveChanges();
        result = RedirectToAction("ShoppingList");
      }
      else
      {
        result = Content("ERROR: This item already exists!"); 
      }

      return result;
    }

    public ActionResult DeleteFromList(String name)
    {
      var itemtoremove = _context.shoppinglistitems.Find(name);
      _context.shoppinglistitems.Remove(itemtoremove);
      _context.SaveChanges();

      return RedirectToAction("ShowShoppingList");
    }

    public ActionResult ShowShoppingList()
    {
      return View(_context.shoppinglistitems);
    }

    public ActionResult UpdateItemAsCompleted(String name)
    {
      var itemtoupdate = _context.shoppinglistitems.Find(name);
      itemtoupdate.iscompleted = true;
      _context.Update(itemtoupdate);
      _context.SaveChanges();

      return RedirectToAction("ShowShoppingList");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
