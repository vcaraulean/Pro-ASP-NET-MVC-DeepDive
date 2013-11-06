using ControllersAndActions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllersAndActions.Controllers
{
    public class BasicController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            var controller = (string)requestContext.RouteData.Values["controller"];
            var action = (string)requestContext.RouteData.Values["action"];

            if (action.ToLower() == "redirect")
                requestContext.HttpContext.Response.Redirect("/Derived/Index");
            else
                requestContext.HttpContext.Response.Write(string.Format("Controller: {0}, Action: {1}", controller, action));
        }
    }

    public class DerivedController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from DerivedController's Index";
            return View("MyView");
        }

        public ActionResult ProduceOutput()
        {
            return new RedirectResult("/Basic/Index");
        }
    }
}