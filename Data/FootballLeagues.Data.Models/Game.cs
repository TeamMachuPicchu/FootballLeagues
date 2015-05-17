namespace FootballLeagues.Data.Models
{
    using System;

    using Contracts;

    public class Game : BaseModel
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public int HomeId { get; set; }

        public virtual Team HomeTeam { get; set; }

        public int AwayId { get; set; }

        public virtual Team AwayTeam { get; set; }

        public int RoundId { get; set; }

        public virtual Round Round { get; set; }
    }
}
