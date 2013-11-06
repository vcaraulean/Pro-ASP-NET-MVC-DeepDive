using Filters.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Controllers
{
    [CustomAuth(true)]
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is the Index action on the Home controller";
        }

        [RangeException]
        public string Range(int id)
        {
            if (id > 100)
            {
                return string.Format("The ID value is {0}", id);
            }

            throw new ArgumentOutOfRangeException("id", id, "");
        }

        [CustomAction]
        public string FilterTest()
        {
            return "Filter action test";
        }

        [ProfileAction]
        public string FilterTest2()
        {
            return "Profiled action";
        }
	}
}