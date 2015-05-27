namespace FootballLeagues.Data.Models
{
    using System.Collections.Generic;

    using Contracts;

    public class Season : BaseModel
    {
        public Season()
        {
            this.SeasonLeagues = new HashSet<LeaguesSeasons>();
        }

        public int Id { get; set; }

        public int StartYear { get; set; }

        public int EndYear { get; set; }

        public virtual ICollection<LeaguesSeasons> SeasonLeagues { get; set; }
    }
}