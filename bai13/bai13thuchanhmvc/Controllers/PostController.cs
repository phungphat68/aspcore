using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai13thuchanhmvc.Controllers
{
   
   
    public class PostController : Controller
    {
        //[Route("baiviet/good")]
        public string good(int a)
        {
            return "bai viet vip" +a;
        }
              

        //[Route("baiviet/Normal/{id?}")]
        public string Normal(string id)
        {
            return "bai viet normal id" +id;
        }
    }

}
