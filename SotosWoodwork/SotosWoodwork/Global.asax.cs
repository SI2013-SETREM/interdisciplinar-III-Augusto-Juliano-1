﻿using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using SotosWoodwork.App_Start;

namespace SotosWoodwork
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
