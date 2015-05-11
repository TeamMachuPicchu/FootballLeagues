using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Nickname { get; set; }

        public DateTime Established { get; set; }

        public string Logo { get; set; }

        public int StadiumId { get; set; }

        public Stadium Stadium { get; set; }

        public int OwnerId { get; set; }

        public virtual Owner Owner { get; set; }

        public int ManagerId { get; set; }

        public virtual Manager Manager { get; set; }

        //public virtual ICollection<Trainer> Trainer { get; set; }

        public virtual ICollection<AppUser> Fans { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}