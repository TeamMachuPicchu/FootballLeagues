using FootballLeagues.Web.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballLeagues.Web.Areas.User.Controllers
{
    public class StatisticsController : Controller
    {
        //
        // GET: /Statistics/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Statistics/player/{playerName}/league/{leagueName}
        public ActionResult PlayerLeague(string playerName, string leagueName)
        {
            var playerId = Players.GetIdByName(playerName);
            var leagueId = Leagues.GetIdByName(leagueName);
            var statistics = Statistics.PlayerLeagueStats(playerId, leagueId);
            return View(statistics);
        }
	}
}