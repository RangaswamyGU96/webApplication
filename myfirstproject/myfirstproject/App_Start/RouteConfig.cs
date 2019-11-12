using myfirstproject.Controllers;
using myfirstproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace myfirstproject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //custome route
            routes.MapMvcAttributeRoutes(); //Attribute routing -> enable here

            // custome routing 
            //routes.MapRoute(
            //    "vehicleLaunchdate",
            //    "vehicle/launchdate/{year}/{month}",
            //    new { Controller = "vehicle" , action= "Bylaunchdate" }

            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
