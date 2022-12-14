using System.Web.Mvc;
using System.Web.Routing;

namespace GameStore.WebUI
{
    public class RouteConfig
        //Запросы на URL маршруты и упращение их
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
            name: "Home",
            url: "",
            defaults: new { controller = "Home", action = "Index" }
        );
            routes.MapRoute(null,
             "",
                        new 
                        {
                                controller = "Game",
                                action = "List",
                                category = (string)null,
                                page = 1
                    }
                );

            routes.MapRoute(
                name: null,
                url: "Page{page}",
                defaults: new { controller = "Game", action = "List", category = (string)"ll"},
                constraints: new { page = @"\d+"}
            );
            routes.MapRoute(null,
                "{category}",
                new { controller = "Game", action = "List", page = 1 }
                );
            routes.MapRoute(null,
                "{category}/Page{page}",
                new { controller = "Game", action = "List" },
                new { page = @"\d+" }
                );
            routes.MapRoute(null, "{controller}/{action}");
            
        }
    }
}
