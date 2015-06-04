namespace FootballLeagues.Web.Controllers
{
    using System.Web.Mvc;
    using Utils;

    public class StatsController : Controller
    {
        //
        // GET: /user/statistics/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /user/statistics/player/{playerName}/league/{leagueName}
        public ActionResult PlayerLeague(string playerName, string leagueName)
        {
            var playerId = Players.GetIdByName(playerName);
            var leagueId = Leagues.GetIdByName(leagueName);
            var statistics = Statistics.PlayerLeagueStats(playerId, leagueId);
            return View(statistics);
        }

        // GET: /user/statistics/player/{playerName}/league/{leagueName}/season/{season}/round/{round}
        public ActionResult PlayerRound(string playerName, string leagueName, string season, int round)
        {
            var playerId = Players.GetIdByName(playerName);
            var leagueId = Leagues.GetIdByName(leagueName);
            var seasonPeriod = Seasons.GetSeasonPeriodFromUrlParameter(season, '-');
            var seasonId = Seasons.GetIdByPeriod(seasonPeriod);
            var leaguesSeasonsId = LeaguesSeasons.GetIdByLeagueAndSeason(leagueId, seasonId);
            var roundId = Rounds.GetRoundId(round, leaguesSeasonsId);
            var statistics = Statistics.PlayerRoundStats(playerId, roundId);
            return View("PlayerLeague", statistics);
        }
	}
}