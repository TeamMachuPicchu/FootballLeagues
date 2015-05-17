namespace FootballLeagues.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Contracts;

    public class League : BaseModel
    {
        public League()
        {
            this.LeagueSeasons = new HashSet<LeaguesSeasons>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Logo { get; set; }

        public virtual ICollection<LeaguesSeasons> LeagueSeasons { get; set; }
    }
}
