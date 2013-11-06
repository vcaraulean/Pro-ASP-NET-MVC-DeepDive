using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllerExtensibility.Infrastructure
{
    public class CustomControllerActivator : IControllerActivator
    {
        public IController Create(RequestContext requestContext, Type controllerType)
        {
            throw new NotImplementedException();
        }
    }
}