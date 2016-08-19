using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace URLRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("CustomerList", "PeopleToKeepHappy",
                new {controller = "customer", action = "List"});

            routes.MapRoute("AdiminPages", "Configuration",
                new {controller = "Admin", action = "Index"});

            routes.MapRoute("TooMuchFun", "Resistance/{name}",
    new { controller = "Home", action = "AnotherVariable" });

            routes.MapRoute("My Route", "{controller}/{action}/{id}", 
                new {controller = "customer", action = "Index", id = 21});
        
        
    }
    }
}
