using FootballLeagues.Data.Common.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballLeagues.Web.Utils
{
    public static class GameStats
    {
        private static readonly FootballData data = new FootballData();

        public static List<int> GetIdsByGameId(int gameId)
        {
            var ids = data.GamesStats.All().Where(gs => gs.GameId == gameId).Select(gs => gs.Id).ToList();

            return ids;
        }

        public static List<int> GetIdsByGameIds(List<int> gameIds)
        {
            var ids = new List<int>();

            foreach (var id in gameIds)
            {
                ids.AddRange(data.GamesStats.All().Where(gs => gs.GameId == id).Select(gs => gs.Id).ToList());
            }

            return ids;
        }

        //public int Goals { get; set; }
        public static int GetTotalPlayerActionsByGameStatsId(int playerId, int gameStatsId, FootballLeagues.Data.Models.Action action)
        {
            int result = data.GamesStats.All().Where(gs => gs.Id == gameStatsId && gs.PlayerId == playerId).Count(gs => (int)gs.Action == (int)action);

            return result;
        }

        public static int GetTotlaPlayerActionsByGameStatsIds(int playerId, List<int> gameStatsIds, FootballLeagues.Data.Models.Action action)
        {
            int result = 0;

            foreach (var id in gameStatsIds)
            {
                result += data.GamesStats.All().Where(gs => gs.Id == id && gs.PlayerId == playerId).Count(gs => (int)gs.Action == (int)action);
            }

            return result;
        }
    }
}