namespace FootballLeagues.Data.Models
{
    using System.Collections.Generic;

    using Contracts;

    public class Round : BaseModel
    {
        public Round()
        {
            this.Games = new HashSet<Game>();
        }

        public int Id { get; set; }

        public int Number { get; set; }

        public virtual ICollection<Game> Games { get; set; }

        public int LeaguesSeasonsId { get; set; }

        public virtual LeaguesSeasons LeagueSeason { get; set; }
    }
}
