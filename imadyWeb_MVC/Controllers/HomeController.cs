using imadyWeb_MVC.Filters;
using Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace imadyWeb_MVC.Controllers
{
    [Localization]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            //ViewData["Title"] = "imady-苏州美娱";
            ViewData["Title"] = Resx_Home_Index.Title;
            //ViewData["Lang"] = HttpContext.Request.Cookies["imadyWeb_MVC.MvcLocalization.CurrentUICulture"].Value;

            return View();
        }

        public ActionResult Index2()
        {
            //ViewData["Title"] = "imady-苏州美娱";
            ViewData["Title"] = Resx_Home_Index.Title;
            return View();
        }

        public ActionResult About()
        {
            //ViewData["Title"] = "imady-关于苏州美娱";
            ViewData["Title"] = Resx_Home_About.Title;

            return View();
        }

        public ActionResult Services()
        {
            //ViewData["Title"] = "imady-产品与服务";
            ViewData["Title"] = Resx_Home_Services.Title;

            return View();
        }

        public ActionResult Portfolio()
        {
            //ViewData["Title"] = "imady-项目案例";
            ViewData["Title"] = Resx_Home_Portfolio.Title;
            return View();
        }

        public ActionResult Yingyu88()
        {

            //ViewData["Title"] = "imady-英语爸爸";
            ViewData["Title"] = Resx_Home_Yingyu88.Title;
            //ViewData["Lang"] = HttpContext.Request.Cookies["imadyWeb_MVC.MvcLocalization.CurrentUICulture"].Value;
            //ViewData["Lang"] = RouteData.Route.GetRouteData(this.HttpContext).Values["lang"];

            return View();
        }


        public ActionResult Contact()
        {
            //ViewData["Title"] = "imady-联络我们";
            ViewData["Title"] = Resx_Home_Contact.Title;

            return View();
        }

        public ActionResult ChangeLanguage()
        {
            var currentlang = Thread.CurrentThread.CurrentUICulture.Name;
            switch(currentlang)
            {
                case "ch": currentlang = "en-US"; break;
                case "zh-CN": currentlang = "en-US"; break;
                case "zh-cn": currentlang = "en-US"; break;
                case "en": currentlang = "zh-CN"; break;
                case "en-US": currentlang = "zh-CN"; break;
                case "en-BT": currentlang = "zh-CN"; break;
                default: currentlang = "zh-CN"; break;
            }
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(currentlang);
            /// 把设置保存进cookie
            HttpCookie _cookie = new HttpCookie("imadyWeb_MVC.MvcLocalization.CurrentUICulture", Thread.CurrentThread.CurrentUICulture.Name);
            _cookie.Expires = DateTime.Now.AddYears(1);
            HttpContext.Response.SetCookie(_cookie);
            return Redirect("~/Home/Index");
        }

        public ActionResult Error()
        {
            ViewData["Title"] = "出错啦！";
            return View();
        }

    }
}