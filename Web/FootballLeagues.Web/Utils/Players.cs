using FootballLeagues.Data.Common.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballLeagues.Web.Utils
{
    public static class Players
    {
        private static readonly FootballData data = new FootballData();

        public static int GetIdByName(string playerName)
        {
            int id = data.Players.All().FirstOrDefault(p => p.Name == playerName || p.Nickname == playerName).Id;

            return id;
        }
    }
}