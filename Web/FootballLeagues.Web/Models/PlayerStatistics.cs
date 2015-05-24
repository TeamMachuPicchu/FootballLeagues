namespace FootballLeagues.Web.Models
{
    public class PlayerStatistics
    {
        public int PlayerId { get; set; }

        public int Games { get; set; }

        public int Goals { get; set; }

        public int Assists { get; set; }

        public int YellowCards { get; set; }

        public int RedCards { get; set; }
    }
}