using System.Collections.Generic;
using System;

namespace BakeryMVC.Models
{
	public class Order
	{//the title --> Vendor X Order No., the description( the price, the date, )
  private static List<Order> _instances = new List<Order> {};
  public int Id { get; } // do not add set;
  public string OrderDescription { get; set; } //what order is for (event,etc) 
  // public int Price { get; set; } // total price // stretch individual line items for nested class orders & prices
  // public int Date { get; set; } // month, day, year
  // public string OrderType { get; set; } //wholesale or retail

  public Order(string orderDescription)
  {
    OrderDescription = orderDescription;
    _instances.Add(this);
    Id = _instances.Count;
  }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    // public static Order Find(int orderId)
    // {
    //   return _instances[orderId-1];
    // } 

    public static void ClearAll()
    {
      _instances.Clear();
    }

	}
}