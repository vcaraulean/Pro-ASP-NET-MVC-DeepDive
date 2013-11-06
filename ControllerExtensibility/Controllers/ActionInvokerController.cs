using ControllerExtensibility.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    public class ActionInvokerController : Controller
    {
        public ActionInvokerController()
        {
            ActionInvoker = new CustomActionInvoker();
        }
        //
        // GET: /ActionInvoker/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }
	}
}