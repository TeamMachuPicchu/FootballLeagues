using FootballLeagues.Data.Common.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballLeagues.Web.Utils
{
    public static class Leagues
    {
        private static readonly FootballData data = new FootballData();

        public static int GetIdByName(string leagueName)
        {
            int id = data.Leagues.All().FirstOrDefault(l => l.Name == leagueName).Id;

            return id;
        }
    }
}