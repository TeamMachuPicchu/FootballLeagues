namespace FootballLeagues.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Contracts;

    public class Team : BaseModel
    {
        public Team()
        {
            this.LeaguesSeasons = new HashSet<LeaguesSeasons>();
            //this.HomeGames = new HashSet<Game>();
            //this.AwayGames = new HashSet<Game>();
            this.Fans = new HashSet<ApplicationUser>();
            this.Players = new HashSet<Player>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public string Nickname { get; set; }

        public DateTime? Established { get; set; }

        public string Logo { get; set; }

        public int StadiumId { get; set; }

        public Stadium Stadium { get; set; }

        // public int OwnerId { get; set; }

        // public virtual Owner Owner { get; set; }

        public int ManagerId { get; set; }

        public virtual Manager Manager { get; set; }

        //public virtual ICollection<Trainer> Trainer { get; set; }

        public virtual ICollection<ApplicationUser> Fans { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<LeaguesSeasons> LeaguesSeasons { get; set; }

        public virtual ICollection<Game> HomeGames { get; set; }

        public virtual ICollection<Game> AwayGames { get; set; }
    }
}