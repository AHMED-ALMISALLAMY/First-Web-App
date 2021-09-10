using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test.Models;


namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Create empty list items
        /// </summary>
        /// <returns></returns>
        public List<Items> CreateListItems()
        {
            List<Items> ListItems = new List<Items>();
            Items oItems = new Items();
            oItems.ItemId = 1;
            oItems.ItemName = "MacBook pro";
            oItems.SalesPrice = 24000;
            oItems.PurchasePrice = 23000;
            ListItems.Add(oItems);

            oItems = new Items();
            oItems.ItemId = 2;
            oItems.ItemName = "Thinkpad x1 carbon";
            oItems.SalesPrice = 27000;
            oItems.PurchasePrice = 34000;
            ListItems.Add(oItems);

            oItems = new Items();
            oItems.ItemId = 3;
            oItems.ItemName = "MacBook Air intel i9";
            oItems.SalesPrice = 43000;
            oItems.PurchasePrice = 45000;

            ListItems.Add(oItems);
            return ListItems;
        }

        public IActionResult Index()
        {
            ViewBag.PageTitle = "Buy a new item from here";
            ViewData["ItemName"] = "MacBook pro";
            return View( CreateListItems() );
        }

        public IActionResult Privacy()
        {

            return View();
        }

        public IActionResult Test()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    } 
}
