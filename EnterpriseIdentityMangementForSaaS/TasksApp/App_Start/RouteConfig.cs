﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TasksApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.MapRoute(
                name: "Account",
                url: "Account/Login",
                defaults: new { controller = "Account", action = "Login" }
            );


            routes.MapRoute(
                name: "HrdAuthentication",
                url: "HrdAuthentication/Login",
                defaults: new { controller = "HrdAuthentication", action = "Login" }
            );

routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

             routes.MapRoute(
                  name: "Tasks",
                  url: "Tasks/{id}",
                  defaults: new { controller = "Tasks", action = "Index", id = UrlParameter.Optional }
              );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}