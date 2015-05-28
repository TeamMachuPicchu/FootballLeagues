namespace FootballLeagues.Web.Utils
{
    using System.Linq;

    using Data.Common.UnitOfWork;

    public static class Players
    {
        private static readonly FootballData data = new FootballData();

        public static int GetIdByName(string playerName)
        {
            int id = data.Players.All().FirstOrDefault(p => p.Name == playerName || p.Nickname == playerName).Id;

            return id;
        }

        public static bool Exists(string playerName)
        {
            return data.Players.All().Any(p => p.Name == playerName);
        }
    }
}