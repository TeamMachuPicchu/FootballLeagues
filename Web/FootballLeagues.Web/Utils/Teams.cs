namespace FootballLeagues.Web.Utils
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using Data.Common.UnitOfWork;

    public class Teams
    {
        private static readonly FootballData data = new FootballData();

      /*  public static List<int> GetTeams(int leagueSeasonId)
        {
            var teamsIds = new List<int>();

            var teams = data.LeaguesSeasons
                .All()
                .FirstOrDefault(t => t.Id == leagueSeasonId);
        } */
    }
}