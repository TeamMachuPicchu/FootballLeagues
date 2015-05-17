namespace FootballLeagues.Data.Models
{
    using System.Collections.Generic;

    public class Owner : Person
    {
        public virtual ICollection<Team> Teams { get; set; }
    }
}
