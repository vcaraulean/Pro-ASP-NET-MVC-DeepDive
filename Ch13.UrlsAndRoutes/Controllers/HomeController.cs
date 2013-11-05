using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch13.UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult CustomVariable(string id = "[default value]")
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "CustomVariable";
            
            ViewBag.CustomVariable = id;

            return View();
        }
    }
}
