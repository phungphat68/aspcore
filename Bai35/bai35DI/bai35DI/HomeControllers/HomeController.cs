using bai35DIservices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace bai35DI.HomeControllers
{
    public class HomeController : Controller
    {
                
        public IActionResult Index([FromServices]IProductService productService)
        {
            var products = productService.GetAll();
            return View(products);
        }
    }
}
