using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TablaChina.Models;


namespace TablaChina.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoadData()
        {
            Item item = new Item();
            item.id = 1;
            item.name = "Item 1";
            item.Price = 10;

            return Json(item);
            
        }

        public IActionResult ShowData()
        {
            return Json("test");
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}

