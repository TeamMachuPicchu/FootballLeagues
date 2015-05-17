namespace FootballLeagues.Web.Utils
{
    using System.Linq;

    using Data.Common.UnitOfWork;

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