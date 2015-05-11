using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Player : Person
    {
        public int TeamId { get; set; }

        public virtual Team CurrentTeam { get; set; }

        public int Number { get; set; }

        public Position Position { get; set; }
    }
}
