using FootballLeagues.Data.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace FootballLeagues.Data.Models
{
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
