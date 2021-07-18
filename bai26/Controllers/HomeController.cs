using bai26.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai26.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new ProductEditModel();
            return View(model);
        }

        public IActionResult Edit()
        {
            var model = new ProductEditModel();
            model.Name = "test";
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(ProductEditModel model)
        {
            string message = string.Empty;
            if (ModelState.IsValid)
            {
                //check product name exist
                if(model.Name == "test") //test nay 4 ki tu nen phai sua
                {
                    ModelState.AddModelError("", "This product name was exists");
                    return View(model);
                }    
                message = "Product: " + model.Name + ". Rate: " + model.Rate + ".Rating: " + model.Rating
                    + "tao san pham thanh cong";
            }    
            else
            {
                return View(model);
            }    
            return Content(message);
        }
    }
}



