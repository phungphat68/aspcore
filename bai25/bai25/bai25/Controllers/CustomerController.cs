using bai25.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai25.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Customer = new Customer(); //cách 1
            ViewData.Model = new Customer(); // Cách 2 Viewdata.Model
            var customer = new Customer(); // cách 3
            return View();
        }
    }
}
