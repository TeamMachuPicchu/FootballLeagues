﻿namespace FootballLeagues.Web.Utils
{
    using System.Collections.Generic;
    using System.Linq;
    
    using Data.Common.UnitOfWork;

    public static class Games
    {
        private static readonly FootballData data = new FootballData();

        public static List<int> GetIdsByRoundId(int roundId)
        {
            var ids = data.Games.All().Where(g => g.RoundId == roundId).Select(g => g.Id).ToList();

            return ids;
        }

        public static List<int> GetIdsByRoundIds(List<int> roundIds)
        {
            var ids = new List<int>();

            foreach (var id in roundIds)
            {
                ids.AddRange(data.Games.All().Where(g => g.RoundId == id).Select(g => g.Id).ToList());
            }

            return ids;
        }
    }
}