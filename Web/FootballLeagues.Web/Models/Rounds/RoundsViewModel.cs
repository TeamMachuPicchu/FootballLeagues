namespace FootballLeagues.Web.Models.Rounds
{
    using Data.Models;
    using Infrastructure.Mapping;

    public class RoundsViewModel : IMapFrom<Round>
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public LeaguesSeasons LeaguesSeasons { get; set; }
    }
}