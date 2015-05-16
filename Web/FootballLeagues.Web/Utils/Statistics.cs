using FootballLeagues.Data.Common.UnitOfWork;
using FootballLeagues.Data.Models;
using FootballLeagues.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballLeagues.Web.Utils
{
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
            statistics.Goals = GameStats.GetTotlaPlayerActionsByGameStatsIds(playerId, gameStatsIds, FootballLeagues.Data.Models.Action.Goal);
            statistics.Assists = GameStats.GetTotlaPlayerActionsByGameStatsIds(playerId, gameStatsIds, FootballLeagues.Data.Models.Action.Assists);
            statistics.YellowCards = GameStats.GetTotlaPlayerActionsByGameStatsIds(playerId, gameStatsIds, FootballLeagues.Data.Models.Action.YellowCard);
            statistics.RedCards = GameStats.GetTotlaPlayerActionsByGameStatsIds(playerId, gameStatsIds, FootballLeagues.Data.Models.Action.RedCard);

            return statistics;
        }
    }
}