namespace FootballLeagues.Data.Models
{
    public class LeaguesSeasons
    {
        public int Id { get; set; }

        public int LeagueId { get; set; }

        public virtual League League { get; set; }

        public int SeasonId { get; set; }

        public virtual Season Season { get; set; }
    }
}
