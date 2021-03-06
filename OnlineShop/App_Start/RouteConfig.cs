﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Home",
            //    url: "Admin/{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    namespaces: new[] { "OnlineShop.Areas.Controllers" }
            //);

            routes.MapRoute(
             name: "Home",
             url: "trang-chu",
             defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
             namespaces: new[] { "OnlineShop.Controllers" }
         );
            routes.MapRoute(
             name: "ProductCategory",
             url: "san-pham/{metatitle}-{id}",
             defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional },
             namespaces: new[] { "OnlineShop.Controllers" }
         );

            routes.MapRoute(
            name: "Product Detail",
            url: "chi-tiet/{metatitle}-{id}",
            defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
            namespaces: new[] { "OnlineShop.Controllers" }
        );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "OnlineShop.Controllers" }
            );
        }
    }
}
