namespace FootballLeagues.Web.Utils
{
    using System.Collections.Generic;
    using System.Linq;

    using Data.Common.UnitOfWork;
    using Microsoft.Ajax.Utilities;

    public static class Rounds
    {
        private static readonly FootballData data = new FootballData();

        public static int GetRoundId(int round, int leaguesSeasonsId)
        {
            var id = data.Rounds.All().FirstOrDefault(r => r.LeaguesSeasonsId == leaguesSeasonsId && r.Number == round).Id;

            return id;
        }

        public static List<int> GetIdsByLeaguesSeasonsId(int leaguesSeasonsId)
        {
            var ids = data.Rounds.All().Where(r => r.LeaguesSeasonsId == leaguesSeasonsId).Select(r => r.Id).ToList();

            return ids;
        }

        public static List<int> GetIdsByLeaguesSeasonsIds(List<int> leagueSeasonIds)
        {
            var ids = data.Rounds.All().Where(r => leagueSeasonIds.Contains(r.LeaguesSeasonsId)).Select(r => r.Id).ToList();
           
            return ids;
        }
    }
}