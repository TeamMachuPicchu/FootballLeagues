
namespace FootballLeagues.Data.Models
{
    using System.Collections.Generic;
    using Contracts;

    public class GameStats : BaseModel
    {
        public int Id { get; set; }

        public int? GameId { get; set; }

        public virtual Game Game { get; set; }

        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }

        public int PlayerId { get; set; }

        public virtual Player Player { get; set; }

        public int Time { get; set; }

        public IDictionary<Action, int> Actions { get; set; }



       
    }
}
