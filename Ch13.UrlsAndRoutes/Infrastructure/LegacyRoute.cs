﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ch13.UrlsAndRoutes.Infrastructure
{
    public class LegacyRoute : RouteBase
    {
        private string[] urls;
        
        public LegacyRoute(params string[] targetUrls)
        {
            this.urls = targetUrls;
        }

        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            RouteData result = null;
            var requestedUrl = httpContext.Request.AppRelativeCurrentExecutionFilePath;
            if (urls.Contains(requestedUrl, StringComparer.OrdinalIgnoreCase))
            {
                result = new RouteData(this, new MvcRouteHandler());
                result.Values.Add("controller", "Legacy");
                result.Values.Add("action", "GetLegacyURL");
                result.Values.Add("legacyURL", requestedUrl);
            }
            return result;
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            VirtualPathData result = null;

            if (values.ContainsKey("legacyURL") && urls.Contains((string)values["legacyURL"], StringComparer.OrdinalIgnoreCase))
            {
                result = new VirtualPathData(this, new UrlHelper(requestContext).Content((string)values["legacyURL"]).Substring(1));
            }

            return result;
        }
    }
}