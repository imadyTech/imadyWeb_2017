using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace imady_ASPNET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "imady-苏州美娱";
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            ViewData["Title"] = "imady-关于苏州美娱";

            return View();
        }

        public IActionResult Services()
        {
            ViewData["Title"] = "imady-产品与服务";

            return View();
        }

        public IActionResult Portfolio()
        {
            ViewData["Title"] = "imady-项目案例";

            return View();
        }

        public IActionResult Yingyu88()
        {
            ViewData["Title"] = "imady-英语爸爸";

            return View();
        }


        public IActionResult Contact()
        {
            ViewData["Title"] = "imady-联络我们";

            return View();
        }

        public IActionResult Error()
        {
            ViewData["Title"] = "出错啦！";
            return View();
        }
    }
}
