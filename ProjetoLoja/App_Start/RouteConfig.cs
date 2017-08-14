using ProjetoLoja.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;

namespace ProjetoLoja
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            {
                routes.MapRoute("ChromeRoute", "{*catchall}",
                new { controller = "Home", action = "Index" },
                new
                {
                    customConstraint = new UserAgentConstraint("Chrome")
                },
                new[] { "ProjetoLoja" });

                routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{*catchall}",
                new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                },
                new[] { "ProjetoLoja" });
            }
        }
    }
}
