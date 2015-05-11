using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Round
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public int SeasonId { get; set; }

        public virtual Season Season { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
