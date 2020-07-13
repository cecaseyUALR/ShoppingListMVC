using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingListMVC.Models
{
  public class ShoppingListItem
  {
    public ShoppingListItem()
    {
      iscompleted = false;
    }

    [Key]
    public string name { get; set; }
    public bool iscompleted { get; set; }
  }
}
