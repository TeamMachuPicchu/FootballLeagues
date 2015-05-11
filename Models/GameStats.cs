using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class GameStats
    {
        public int Id { get; set; }
        public int? GameId { get; set; }

        public virtual Game Game { get; set; }

        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }

        public int PlayerId { get; set; }

        public virtual Player Player { get; set; }

        public int Time { get; set; }

        public Action Action { get; set; }



       
    }
}
