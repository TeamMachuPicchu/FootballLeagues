namespace FootballLeagues.Web.Models.League
{
    using System.Collections;
    using Data.Models;
    using Infrastructure.Mapping;

    public class LeagueViewModel : IMapFrom<League>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public IEnumerable LeaguesSeasons { get; set; }
    }
}