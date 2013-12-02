using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcModels.Models;

namespace MvcModels.Controllers
{
    public class HomeController : Controller
    {
        private Person[] personData =
        {
            new Person {PersonId = 1, FirstName = "Adam", LastName = "Freeman", Role = Role.Admin},
            new Person {PersonId = 2, FirstName = "Steven", LastName = "Sanderson", Role = Role.Admin},
            new Person {PersonId = 3, FirstName = "Jacqui", LastName = "Griffyth", Role = Role.User},
            new Person {PersonId = 4, FirstName = "John", LastName = "Smith", Role = Role.User},
            new Person {PersonId = 5, FirstName = "Anne", LastName = "Jones", Role = Role.Guest},
        };

        public ActionResult Index(int id)
        {
            var person = personData.First(p => p.PersonId == id);
            return View(person);
        }

        public ActionResult CreatePerson()
        {
            return View(new Person());
        }
        
        [HttpPost]
        public ActionResult CreatePerson(Person model)
        {
            return View("Index", model);
        }

        public ActionResult DisplaySummary([Bind(Prefix = "Address")] AddressSummary addressSummary)
        {
            return View(addressSummary);
        }

        public ActionResult Names(IList<string> names)
        {
            names = names ?? new List<string>();
            return View(names);
        }

        public ActionResult Address(FormCollection form)
        {
            var addresses = new List<AddressSummary>();
            UpdateModel(addresses, form);
            return View(addresses);
        }
    }
}
