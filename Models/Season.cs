using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Season
    {
        public int Id { get; set; }

        public int StartYear { get; set; }

        public int EndYear { get; set; }

        public virtual ICollection<Round> Rounds { get; set; }
    }
}
