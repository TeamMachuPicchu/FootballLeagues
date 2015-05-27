namespace FootballLeagues.Web.Models.LeagueSeason
{
    using Data.Models;
    using Infrastructure.Mapping;

    public class LeaguesSeasonsViewModel : IMapFrom<LeaguesSeasons>
    {
        public int LeagueId { get; set; }

        public int StartYear { get; set; }

        public int EndYear { get; set; }

        public Season Season { get; set; }

        public League League { get; set; }
    }
}