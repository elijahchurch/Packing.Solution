using Microsoft.AspNetCore.Mvc;
using Packing.Models;
using System.Collections.Generic;

namespace Packing.Controllers
{
    public class ItemController : Controller
    {
        [HttpGet("/items")]

        public ActionResult Index(){
            List<Item> fullList = Item.GetAll();
        return View(fullList);
        }

        [HttpGet("/items/new")]
        public ActionResult New(){
            return View();
        }

        [HttpPost("/items")]
        public ActionResult Create(string itemName, string itemDescription, string status) 
        {
            Item newItem = new Item(itemName, itemDescription, status);
            return RedirectToAction("Index");
        }

        [HttpGet("/items/{id}")]
        public ActionResult Show(int id)
        {
            Item foundItem = Item.Findthingy(id);
            return View(foundItem);
        }
        [HttpPost("/items/delete")]
        public ActionResult DeleteAll()
        {
            Item.ClearAll();
            return View();
        }

        [HttpPost("/items/{id}/delete")]
        public ActionResult Delete(int id)
        {
            Item foundItem = Item.Findthingy(id);
            Item.Delete(foundItem);
            return RedirectToAction("Index");
        }
    }
}