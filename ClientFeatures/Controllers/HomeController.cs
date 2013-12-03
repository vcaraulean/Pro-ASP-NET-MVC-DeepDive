using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClientFeatures.Models;

namespace ClientFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult MakeBooking()
        {
            return View(new Appointment
            {
                ClientName = "Microsoft",
                Date = DateTime.Now.AddDays(3),
                TermsAccepted = true,
            });
        }

        [HttpPost]
        public JsonResult MakeBooking(Appointment appointment)
        {
            return Json(appointment, JsonRequestBehavior.AllowGet);
        }
    }
}
