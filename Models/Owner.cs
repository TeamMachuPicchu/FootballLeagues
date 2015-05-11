using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Owner : Person
    {
        public virtual ICollection<Team> Teams { get; set; }
    }
}
