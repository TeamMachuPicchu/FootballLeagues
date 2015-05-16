using FootballLeagues.Data.Common.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballLeagues.Web.Utils
{
    public static class Rounds
    {
        private static readonly FootballData data = new FootballData();

        public static List<int> GetIdsByLeaguesSeasonsId(int leaguesSeasonsId)
        {
            var ids = data.Rounds.All().Where(r => r.LeaguesSeasonsId == leaguesSeasonsId).Select(r => r.Id).ToList();

            return ids;
        }

        public static List<int> GetIdsByLeaguesSeasonsIds(List<int> leagueSeasonIds)
        {
            var ids = new List<int>();
            foreach (var id in leagueSeasonIds)
            {
                ids.AddRange(data.Rounds.All().Where(r => r.LeaguesSeasonsId == id).Select(r => r.Id).ToList());
            }
           
            return ids;
        }
    }
}