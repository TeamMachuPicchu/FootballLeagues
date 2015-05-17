namespace FootballLeagues.Data.Models
{
    public class Player : Person
    {
        public int TeamId { get; set; }

        public virtual Team CurrentTeam { get; set; }

        public int Number { get; set; }

        public Position Position { get; set; }
    }
}
