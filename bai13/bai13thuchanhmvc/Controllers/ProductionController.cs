using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai13thuchanhmvc.Controllers
{
    public class ProductionController : Controller
    {
        //[Route("Production/modify")]
        //[ActionName("modify")] 
        public string Edit()
        {
            return "xin chao modify";
        }
    }
}
