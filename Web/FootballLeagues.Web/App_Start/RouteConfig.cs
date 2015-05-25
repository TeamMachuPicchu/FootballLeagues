namespace FootballLeagues.Web
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Rounds",
                url: "{league}/{season}/{controller}/{action}/{number}/{roundId}",
                defaults: new { controller = "Rounds", action = "View"}
                );
            
            routes.MapRoute(
              name: "GameDetails",
              url: "{controller}/{action}/{teams}/{season}/round/{round}/{gameId}",
              defaults: new { controller = "Game", action = "Details" }
            );          

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
