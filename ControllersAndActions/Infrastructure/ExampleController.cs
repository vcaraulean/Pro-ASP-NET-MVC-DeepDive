using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Infrastructure
{
    public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            return View("Homepage");
        }

        public ViewResult Index2()
        {
            return View((object)"Hello");
        }

        public ViewResult Index3()
        {
            ViewBag.Message = "hello";
            ViewBag.Date = DateTime.Now;

            return View();
        }

        public RedirectResult Redirect()
        {
            return Redirect("/Example/Index");
        }

        public RedirectToRouteResult Redirect2()
        {
            return RedirectToRoute(new { controller = "Example", action = "Index", ID = "MyID" });
        }
	}
}