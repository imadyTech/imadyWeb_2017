using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace imadyweb_AspNet.Controllers
{
    public class Yingyu88Controller : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Title"] = "英语爸爸 - 整合式英语学习服务";

            return View();
        }
    }
}
