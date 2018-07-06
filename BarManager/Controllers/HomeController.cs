using BarManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Warehouse()
        {
            List<Item> items = new List<Item>
            {
                new Item("Coca cola", 13),
                new Item("Pepsi", 8),
                new Item("Fanta", 9),
                new Item("Sprite", 19)
            };

            return View(items);
        }

        public ActionResult Traffic()
        {
            return View();
        }
    }
}