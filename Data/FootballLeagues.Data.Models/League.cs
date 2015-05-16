using FootballLeagues.Data.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagues.Data.Models
{
    public class League : BaseModel
    {
        public League()
        {
            this.LeagueSeasons = new HashSet<LeaguesSeasons>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public virtual ICollection<LeaguesSeasons> LeagueSeasons { get; set; }
    }
}
