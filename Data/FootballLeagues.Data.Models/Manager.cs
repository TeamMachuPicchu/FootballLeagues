namespace FootballLeagues.Data.Models
{
    using System.Collections.Generic;

    public class Manager : Person
    {
        public virtual ICollection<Team> Teams { get; set; }
    }
}
