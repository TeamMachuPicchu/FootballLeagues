namespace FootballLeagues.Web.Utils
{
    using System.Collections.Generic;
    using System.Linq;

    using Data.Common.UnitOfWork;
    using FootballLeagues.Web.Models;

    public static class LeaguesSeasons
    {
        private static readonly FootballData data = new FootballData();

        public static List<int> GetIdsByLeague(int leagueId)
        {
            var ids = data.LeaguesSeasons.All().Where(ls => ls.LeagueId == leagueId).Select(ls => ls.Id).ToList();
            return ids;
        }

        public static int GetIdByLeagueAndSeason(int leagueId, int seasonId)
        {
            var id = data.LeaguesSeasons.All().FirstOrDefault(ls => ls.LeagueId == leagueId && ls.SeasonId == seasonId).Id;
            return id;
        }
    }
}