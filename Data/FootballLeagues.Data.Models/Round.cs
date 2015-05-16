using FootballLeagues.Data.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagues.Data.Models
{
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
