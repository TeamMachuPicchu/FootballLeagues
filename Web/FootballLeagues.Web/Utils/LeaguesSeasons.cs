namespace FootballLeagues.Web.Utils
{
    using System.Collections.Generic;
    using System.Linq;

    using Data.Common.UnitOfWork;

    public static class LeaguesSeasons
    {
        private static readonly FootballData data = new FootballData();

        public static List<int> GetIdsByLeague(int leagueId)
        {
            var ids = data.LeaguesSeasons.All().Where(ls => ls.LeagueId == leagueId).Select(ls => ls.Id).ToList();
            return ids;
        }
    }
}