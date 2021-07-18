using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai13thuchanhmvc.Controllers
{
    [Route("khachhang")]
    public class CustomerController : Controller
    {
        [Route("khachhang/vip")]
        public string Vip()
        {
            return "Khach hang vip";
        }

        [Route("")]// đoạn này bài 16 bị lỗi,
                   // hết lỗi khi khai báo khách hàng ở trên
                   // nếu vào khách hàng mặc định vô normal vì có [Route("")] trước normal

        [Route("khachhang/normal/{id?}")]
        public string Normal(int id)
        {
            return "Khach hang normal id" +id;
        }
    }

}
