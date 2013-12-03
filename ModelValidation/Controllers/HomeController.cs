using System;
using System.Web.Mvc;
using ModelValidation.Models;

namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult MakeBooking()
        {
            return View(new Appointment {Date = DateTime.Now});
        }

        [HttpPost]
        public ViewResult MakeBooking(Appointment appointment)
        {
            if (ModelState.IsValid)
                return View("Completed", appointment);
            
            return View();
        }

        public JsonResult ValidateDate(string Date)
        {
            DateTime parsedDate;
            if (!DateTime.TryParse(Date, out parsedDate))
                return Json("Please enter a valid date (mm/dd/yyyy)", JsonRequestBehavior.AllowGet);
            if (DateTime.Now > parsedDate)
                return Json("Please provide a date in the future", JsonRequestBehavior.AllowGet);
            
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}