namespace FootballLeagues.Web.Models
{
    using Data.Models;
    using Infrastructure.Mapping;

    public class GameViewModel : IMapFrom<Game>
    {
        public int Id { get; set; }

        public Team HomeTeam { get; set; }

        public Team AwayTeam { get; set; }

        public int HomeGoals { get; set; }

        public int AwayGoals { get; set; }

        public int Attendance { get; set; }

        public int HomeShots { get; set; }

        public int AwayShots { get; set; }

        public int HomeShotsOnTarget { get; set; }

        public int AwayShotsOnTarget { get; set; }

        public int HomeCorners { get; set; }

        public int AwayCorners { get; set; }

        public Round Round { get; set; }
    }
}