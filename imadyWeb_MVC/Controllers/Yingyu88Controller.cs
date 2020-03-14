using imadyWeb_MVC.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace imadyWeb_MVC.Controllers
{
    public class Yingyu88Controller : Controller
    {
        // GET: /<controller>/
        [Localization]
        public ActionResult Evolution()
        {
            ViewData["Title"] = "英语爸爸 - 项目变迁历程";

            return View();
        }

        public ActionResult NewZealand()
        {
            {
                ViewData["Title"] = "新西兰游学";

                return View();
            }
        }
    }
}
