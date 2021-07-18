using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLayout.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            ViewData["Greeting"] = "Hello World!";
            ViewBag.Product = new ProductModel()
            {
                Id=1,
                Name = " Sua ong tho",
                Brand = " Khong",
                Price = 1000              
                
            };
            return View();
        }
    }
}
