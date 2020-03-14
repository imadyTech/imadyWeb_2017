using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace imadyweb_AspNet.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: /<controller>/
        public IActionResult Electric()
        {
            ViewData["Title"] = "案例-高压电力设备仿真培训系统";

            return View();
        }
    }
}
