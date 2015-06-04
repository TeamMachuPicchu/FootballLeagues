namespace FootballLeagues.Web.Utils
{
    using Data.Common.UnitOfWork;
    using Data.Models;
    using Models;

    public static class Statistics
    {
        private static readonly FootballData data = new FootballData();

        public static PlayerStatistics PlayerLeagueStats(int playerId, int leagueId) 
        {
            PlayerStatistics statistics = new PlayerStatistics();

            var leagueSeasoonsIds = LeaguesSeasons.GetIdsByLeague(leagueId);
            var roundsIds = Rounds.GetIdsByLeaguesSeasonsIds(leagueSeasoonsIds);
            var gameIds = Games.GetIdsByRoundIds(roundsIds);
            var gameStatsIds = GameStats.GetIdsByGameIds(gameIds);

            statistics.PlayerId = playerId;
            statistics.Games = gameIds.Count;
            statistics.Goals = GameStats.GetTotlaPlayerActionsByGameStatsIds(playerId, gameStatsIds, Action.Goal);
            statistics.Assists = GameStats.GetTotlaPlayerActionsByGameStatsIds(playerId, gameStatsIds, Action.Assists);
            statistics.YellowCards = GameStats.GetTotlaPlayerActionsByGameStatsIds(playerId, gameStatsIds, Action.YellowCard);
            statistics.RedCards = GameStats.GetTotlaPlayerActionsByGameStatsIds(playerId, gameStatsIds, Action.RedCard);
            return statistics;
        }

        public static PlayerStatistics PlayerRoundStats(int playerId, int roundId)
        {
            PlayerStatistics statistics = new PlayerStatistics();

            var gameIds = Games.GetIdsByRoundId(roundId);
            var gameStatsIds = GameStats.GetIdsByGameIds(gameIds);

            statistics.PlayerId = playerId;
            statistics.Games = gameIds.Count;
            statistics.Goals = GameStats.GetTotlaPlayerActionsByGameStatsIds(playerId, gameStatsIds, Action.Goal);
            statistics.Assists = GameStats.GetTotlaPlayerActionsByGameStatsIds(playerId, gameStatsIds, Action.Assists);
            statistics.YellowCards = GameStats.GetTotlaPlayerActionsByGameStatsIds(playerId, gameStatsIds, Action.YellowCard);
            statistics.RedCards = GameStats.GetTotlaPlayerActionsByGameStatsIds(playerId, gameStatsIds, Action.RedCard);
            return statistics;
        }
    }
}