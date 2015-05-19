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

        public int HomeGoals { get; set; }

        public int AwayGoals { get; set; }

        public int Attendance { get; set; }

        public int HomeShots { get; set; }

        public int AwayShots { get; set; }

        public int HomeShotsOnTarget { get; set; }

        public int AwayShotsOnTarget { get; set; }

        public int HomeCorners { get; set; }

        public int AwayCorners { get; set; }

        public int HomeFouls { get; set; }

        public int AwayFouls { get; set; }

        public int HomeYellowCards { get; set; }

        public int AwayYellowCards { get; set; }

        public int HomeRedCards { get; set; }

        public int AwayRedCards { get; set; }

        public int RoundId { get; set; }

        public virtual Round Round { get; set; }
    }
}
