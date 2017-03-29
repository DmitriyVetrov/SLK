using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Slk.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Auth",
                url: "auth/",
                defaults: new { controller = "Account", action = "Login" },
                namespaces: new[] { "Slk.Web.Controllers" }
            );

            routes.MapRoute(
                name: "Signup",
                url: "signup/",
                defaults: new { controller = "Account", action = "Register" },
                namespaces: new[] { "Slk.Web.Controllers" }
            );

            routes.MapRoute(
                name: "Auth_LogOff",
                url: "auth/logoff",
                defaults: new { controller = "Account", action = "LogOff" },
                namespaces: new[] { "Slk.Web.Controllers" }
            );

            routes.MapRoute(
                name: "About",
                url: "about/",
                defaults: new { controller = "Home", action = "About" },
                namespaces: new[] { "Slk.Web.Controllers" }
            );

            routes.MapRoute(
                name: "Contact",
                url: "contact/",
                defaults: new { controller = "Home", action = "Contact" },
                namespaces: new[] { "Slk.Web.Controllers" }
            );

            routes.MapRoute(
                name: "Photos",
                url: "photos/",
                defaults: new { controller = "Home", action = "Photos" },
                namespaces: new[] { "Slk.Web.Controllers" }
            );

            routes.MapRoute(
                name: "TopicArticle",
                url: "{topic}/{article}",
                defaults: new { controller = "Guide", action = "Index", topic = UrlParameter.Optional, article = UrlParameter.Optional },
                namespaces: new[] { "Slk.Web.Controllers" }
            );

        }
    }
}
