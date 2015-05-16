using FootballLeagues.Data.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagues.Data.Models
{
    public class Season : BaseModel
    {
        public Season()
        {
            this.SeasonLeagues = new HashSet<LeaguesSeasons>();
        }

        public int Id { get; set; }

        public int StartYear { get; set; }

        public int EndYear { get; set; }

        public virtual ICollection<LeaguesSeasons> SeasonLeagues { get; set; }
    }
}
