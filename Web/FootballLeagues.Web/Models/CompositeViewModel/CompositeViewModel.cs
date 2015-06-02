namespace FootballLeagues.Web.Models.CompositeViewModel
{
    using Data.Models;

    public class CompositeViewModel
    {
        public int LeagueId { get; set; }

        public int StartYear { get; set; }

        public int EndYear { get; set; }

        public Season Season { get; set; }

        public League League { get; set; }

        public int Id { get; set; }

        public int Number { get; set; }

        public LeaguesSeasons LeaguesSeasons { get; set; }

        public string LeagueName { get; set; }

        public string SeasonPeriod { get; set; }
    }
}