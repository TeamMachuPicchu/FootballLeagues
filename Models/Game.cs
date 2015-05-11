using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Game
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
