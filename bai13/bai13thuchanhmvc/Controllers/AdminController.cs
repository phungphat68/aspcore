using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai13thuchanhmvc.Controllers
{
    public class AdminController : Controller
    {
        public string Index()
        {
            return " xin chao ban den voi admin";
        }
    }
}
