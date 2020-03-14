using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace imadyWeb_MVC
{
    /* 原代码，测试globalization暂时保留
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
    */

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              "Localization", // 路由名称
              "{controller}/{action}/{lang}", // 带有参数的 URL
              new {controller = "Home", action = "Index", lang = UrlParameter.Optional }//参数默认值
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{lang}",
                defaults: new { controller = "Home", action = "Index", lang = UrlParameter.Optional }
            );
        }


    }
}
