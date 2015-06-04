namespace FootballLeagues.Web.Utils
{
    using System.Collections.Generic;
    using System.Linq;

    using Data.Common.UnitOfWork;
    using Data.Models;

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
            var ids = data.GamesStats.All().Where(gs => gameIds.Contains((int)gs.GameId)).Select(gs => gs.Id).ToList();

            return ids;
        }

        //public int Goals { get; set; }
        public static int GetTotalPlayerActionsByGameStatsId(int playerId, int gameStatsId, Action action)
        {
            int result = data.GamesStats.All().Where(gs => gs.Id == gameStatsId && gs.PlayerId == playerId).Count(gs => (int)gs.Action == (int)action);

            return result;
        }

        // Changed type in game stats. 
        public static int GetTotlaPlayerActionsByGameStatsIds(int playerId, List<int> gameStatsIds, Action action)
        {
            int result = data.GamesStats.All().Where(gs => gameStatsIds.Contains(gs.Id) && gs.PlayerId == playerId).Count(gs => (int)gs.Action == (int)action);
            return result;
        }
    }
}