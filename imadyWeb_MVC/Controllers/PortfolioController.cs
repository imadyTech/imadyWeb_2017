using imadyWeb_MVC.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace imadyWeb_MVC.Controllers
{
    [Localization]
    public class PortfolioController : Controller
    {
        // GET: /<controller>/
        public ActionResult Electric()
        {
            ViewData["Title"] = "案例-高压电力设备仿真培训系统";
            ViewData["Lang"] = HttpContext.Request.Cookies["imadyWeb_MVC.MvcLocalization.CurrentUICulture"].Value;

            return View();
        }
    }
}
