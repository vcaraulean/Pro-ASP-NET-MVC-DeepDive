using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Infrastructure
{
    public class ProfileActionAttribute : FilterAttribute, IActionFilter
    {
        Stopwatch stopwatch;
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            stopwatch.Stop();

            filterContext.HttpContext.Response.Write(string.Format("<div>Action elapsed time: {0}</div>", stopwatch.Elapsed.TotalSeconds));
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            stopwatch = Stopwatch.StartNew();
        }
    }
}