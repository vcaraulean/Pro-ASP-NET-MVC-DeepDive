using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelperMethods.Models;

namespace HelperMethods.Controllers
{
    public class PeopleController : Controller
    {
        private Person[] personData =
        {
            new Person {FirstName = "Adam", LastName = "Freeman", Role = Role.Admin},
            new Person {FirstName = "Steven", LastName = "Sanderson", Role = Role.Admin},
            new Person {FirstName = "Jacqui", LastName = "Griffyth", Role = Role.User},
            new Person {FirstName = "John", LastName = "Smith", Role = Role.User},
            new Person {FirstName = "Anne", LastName = "Jones", Role = Role.Guest},
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetPeople(string selectedRole = "All")
        {
            return View((object)selectedRole);
        }

        public PartialViewResult GetPeopleData(string selectedRole = "All")
        {
            var data = GetData(selectedRole);
            return PartialView(data);
        }

        public JsonResult GetPeopleDataJson(string selectedRole = "All")
        {
            return Json(GetData(selectedRole), JsonRequestBehavior.AllowGet);
        }

        private IEnumerable<Person> GetData(string selectedRole)
        {
            IEnumerable<Person> data = personData;
            if (selectedRole != "All")
            {
                var selected = (Role) Enum.Parse(typeof (Role), selectedRole);
                data = personData.Where(p => p.Role == selected);
            }
            return data;
        }
    }
}
