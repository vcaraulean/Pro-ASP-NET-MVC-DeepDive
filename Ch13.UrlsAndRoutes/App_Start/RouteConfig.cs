﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ch13.UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //var route = new Route("{controller}/{action}", new MvcRouteHandler());
            //routes.Add("myRoute", route);

            routes.MapRoute("ShopSchema2", "Shop/OldAction", new { controller = "Home", action = "index" });

            routes.MapRoute("ShopSchema", "Shop/{action}", new { controller = "Home"});

            routes.MapRoute("", "X{controller}/{action}");

            routes.MapRoute("myRoute", "{controller}/{action}/{id}/{*catchall}", new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute("", "Public/{controller}/{action}", new { controller = "Home", action = "Index" });
        }
    }
}
