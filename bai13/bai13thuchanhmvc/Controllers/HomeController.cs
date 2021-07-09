using bai13thuchanhmvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai13thuchanhmvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            var model = new IndexModel();
            model.Message = "Hello from model, có id là" +id;
            return View(model);
        }
    }
}
