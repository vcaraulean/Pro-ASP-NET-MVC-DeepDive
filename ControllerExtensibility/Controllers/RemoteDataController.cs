using ControllerExtensibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    public class RemoteDataController : AsyncController
    {
        public async Task<ActionResult> Data()
        {
            //var service = new RemoteService();
            //var data = service.GetRemoteData();

            var data = await Task<string>.Factory.StartNew(() => new RemoteService().GetRemoteData());
            return View((object)data);
        }

        public async Task<ActionResult> DataAsync()
        {
            var data = await new RemoteService().GetRemoteDataAsync();
            return View((object)data);
        }
	}
}