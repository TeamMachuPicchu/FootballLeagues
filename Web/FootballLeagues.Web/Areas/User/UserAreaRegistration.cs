using System.Web.Mvc;

namespace FootballLeagues.Web.Areas.User
{
    public class UserAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "User";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "User_Player_Statistics_League",
                "user/{controller}/player/{playerName}/league/{leagueName}",
                new { action = "PlayerLeague", playerName = @"\w+", leagueName = @"\w+" }
            );

            context.MapRoute(
                "User_default",
                "user/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}