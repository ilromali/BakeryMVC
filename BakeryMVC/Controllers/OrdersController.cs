using Microsoft.AspNetCore.Mvc;
using BakeryMVC.Models;
using System.Collections.Generic;

namespace BakeryMVC.Controllers
{
  public class OrdersController : Controller
  {

    // [HttpGet("/categories/{categoryId}/items/new")]
    // public ActionResult New(int categoryId)
    // {
    //   Category category = Category.Find(categoryId);
    //   return View(category);
    // } //offers form to create new Item w/in specific Category

    // [HttpGet("/categories/{categoryId}/items/{itemId}")]
    // public ActionResult Show(int categoryId, int itemId)
    // {
    //   Item item = Item.Find(itemId);
    //   Category category = Category.Find(categoryId);
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //     model.Add("item", item);
    //     model.Add("category", category);
    //     return View(model);
    // } //Displays details for a specific Item associated w/ a Category

    // [HttpPost("/items/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Item.ClearAll();
    //   return View();
    // }
  }
}